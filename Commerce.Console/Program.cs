using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Commerce.Data;
using System.Xml.Serialization;
using System.Diagnostics;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace Commerce.ConsoleApp {
    public class Program {
        static void Main(string[] args) {
            var serialList = new XmlSerializer(typeof(List<MongoProduct>));
            var serial = new XmlSerializer(typeof(MongoProduct));
            var path = @"..\..\..\data\";

            var list = new List<MongoProduct>();

            using (var fs = File.OpenRead(path + "products.xml")) {
                list = serialList.Deserialize(fs) as List<MongoProduct>;
            }


            //must be done first
            var collection = Collections.ProductCollection;


            //LoadMongoData(list);

            //PopulateSqlDatabase(list);

            //Lets find and Modify

            //CreateMongoDbOrder();
            CreateSqlOrder();

            //AddColumn();
            //RemoveColumn();
            //UpdateDocumentsWithNewKeyword();
            //UpdateAllDocuments();
            //FindAndModify();

            //list.First().ASIN;

            var asinName = "B00000J1TX";

            var query = Query<MongoProduct>
                .Where(item => item.ASIN == asinName);

            var asin = Collections.ProductCollection.FindOne(query);

            //query = Query<MongoProduct>.Where(item => item.ListPriceInteger < 9.99m * 10000);
            //var itemsUnder999 = Collections.ProductCollection.FindAs<MongoProduct>(query).ToList();

            Collections.ProductCollection.Distinct("Title", query);

            query = Query<MongoProduct>.Where(item => item.PackageDimensions.Weight < .1m);
            var itemsVeryLight = Collections.ProductCollection.FindAs<MongoProduct>(query).ToList();

            Collections.ProductCollection.Find(query).SetSortOrder(SortBy<MongoProduct>.Ascending(item => item.Title));

            //var query = Query<MongoProduct>.Where(item => item.ListPrice < 4.99m);
            //var count = Collections.ProductCollection.Count(query);

            //Collections.ProductCollection.FindAll();

            //does work
            var asin2 = Collections.ProductCollection.Find(query).SetFields(Fields.Include("listPrice", "title")).FirstOrDefault();
            //does not work
            var asin2a = Collections.ProductCollection.Find(query).SetFields(Fields.Include("ListPriceInteger", "Title")).FirstOrDefault();

            //must be the c# class properties.
            var asin3 = Collections.ProductCollection.Find(query).SetFields(Fields<MongoProduct>.Include(c => c.ListPriceInteger, c => c.Title)).FirstOrDefault();

            var product = new MongoProduct() { };

            //Collections.ProductCollection.Save<MongoProduct>(product);

            System.Console.ReadLine();

        }

        private static void LoadMongoData(List<MongoProduct> list) {

            var sw = new Stopwatch();
            sw.Start();

            Collections.ProductCollection.InsertBatch<MongoProduct>(list);

            sw.Stop();
            System.Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadLine();
        }

        private static void CreateSqlOrder() {
            using (var uow = CommerceModelUnitOfWork.UnitOfWork()) {
                //lets grab up a few products.
                var products = new List<Product>();
                var asinList = new string[] {"B00000J1EQ",
                                        "B00002CF9M",
                                        "B00002S932",
                                        "B00004UE3D",
                                        "B00004XSAE" };

                foreach (var asin in asinList) {
                    var query = Query<Product>
                        .Where(item => item.Asin == asin);
                    var product = uow.Products.FirstOrDefault(item => item.Asin == asin);
                    products.Add(product);
                }

                var customer = new Customer() {
                    Address1 = "123 Main Street",
                    City = "Simpsonville",
                    Country = "US",
                    Email = "me@home.com",
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "555-867-5309",
                    StateOrProvince = "SC"
                };

                uow.Add(customer);

                var order = new Order() {
                    Customer = customer,
                    OrderDate = DateTime.Now,
                    ShipTo = customer,
                    Status = (int)OrderStatus.New
                };

                uow.Add(order);

                foreach (var product in products) {
                    var orderDetail = new OrderDetail() {
                        Order = order,
                        Product = product,
                        OrderedQuantity = 2,
                        Quantity = 2,
                        UnitPrice = 19.95m
                    };
                    uow.Add(orderDetail);
                }
                uow.SaveChanges();
            }
        }

        private static void CreateMongoDbOrder() {
            //lets grab up a few products.
            var products = new List<MongoProduct>();
            var asinList = new string[] {"B00000J1EQ",
                                        "B00002CF9M",
                                        "B00002S932",
                                        "B00004UE3D",
                                        "B00004XSAE" };

            foreach (var asin in asinList) {
                var query = Query<MongoProduct>
                    .Where(item => item.ASIN == asin);
                var product = Collections.ProductCollection.FindOneAs<MongoProduct>(query);
                products.Add(product);
            }

            var customer = new MongoCustomer() {
                Address1 = "123 Main Street",
                City = "Simpsonville",
                CustomerId = Guid.NewGuid(),
                Country = "US",
                Email = "me@home.com",
                FirstName = "John",
                LastName = "Doe",
                Phone = "555-867-5309",
                StateOrProvince = "SC"
            };

            Collections.CustomerCollection.Save(customer);

            var order = new MongoOrder() {
                Customer = customer,
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                ShipTo = customer,
                Status = OrderStatus.New
            };

            foreach (var product in products) {
                order.Details.Add(new MongoOrderItem() {
                    ASIN = product.ASIN,
                    OrderedQuantity = 2,
                    Quantity = 2,
                    Title = product.Title,
                    UnitPrice = 19.95m
                });
            }

            Collections.OrderCollection.Save(order);

            //now create the same order with FK

            order = new MongoOrder() {
                CustomerId = customer.CustomerId,
                OrderId = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                ShipToCustomerId = customer.CustomerId,
                Status = OrderStatus.New
            };

            foreach (var product in products) {
                order.Details.Add(new MongoOrderItem() {
                    ASIN = product.ASIN,
                    OrderedQuantity = 2,
                    Quantity = 2,
                    Title = product.Title,
                    UnitPrice = 19.95m
                });
            }

            Collections.OrderCollection.Save(order);

        }

        //var query2 = Query<MongoProductView>.EQ(item => item.ASIN, asinName);

        private static void FindAndModify() {
            var asinName = "B00000J1TX";
            var query = Query.And(Query.EQ("_id", asinName));
            var sortBy = SortBy.Null;
            var update = Update.Inc("counter", 1).Set("lastView", DateTime.Now)
                .SetOnInsert("keywords", new BsonArray(new[] { "new" }));
            var result = Collections.ProductViewCollection
                .FindAndModify(query, sortBy, update, true, true);

            var found = Collections.ProductViewCollection.FindOne(query);

            Console.WriteLine("");
        }

        private static void AddColumn() {
            var sortBy = SortBy.Null;
            var update = Update.Set("extra", "");
            var result = Collections.ProductViewCollection
                .Update(null, update);

            Console.WriteLine("");
        }

        private static void RemoveColumn() {
            var sortBy = SortBy.Null;
            var update = Update.Unset("extra");
            var result = Collections.ProductViewCollection
                .Update(null, update);

            Console.WriteLine("");
        }

        private static void AddIndex() {
            Collections.ProductViewCollection.EnsureIndex(IndexKeys<MongoProductView>.Ascending(item => item.Counter), IndexOptions.SetBackground(true));

            Console.WriteLine("");
        }

        private static void DeleteTable() {
            Collections.ProductViewCollection.Drop();

        }

        private static void UpdateAllDocuments() {
            var sortBy = SortBy.Null;
            var update = Update.Inc("counter", 1);
            var result = Collections.ProductViewCollection
                .Update(null, update);

            Console.WriteLine("");
        }

        //update = Update<MongoProductView>.AddToSet<string>(item => item.Keywords.AsEnumerable(), new string[] { "test" });

        private static void UpdateDocumentsWithNewKeyword() {
            var array = new List<string>() { "new" };
            var query = Query<MongoProductView>.All(item => item.Keywords, array);
            //show that we did return a product.
            var found = Collections.ProductViewCollection.Find(query).ToList();
            //Add keyword to all documents that have a keyword of new
            var update = Update.AddToSet("keywords", "test");
            //you could also use push if you wanted it added no matter what.
            //var update = Update.Push("keywords", "test");
            Collections.ProductViewCollection.Update(query, update);

            Console.WriteLine("");
        }

        private static void PopulateSqlDatabase(List<MongoProduct> list) {

            using (var uow = CommerceModelUnitOfWork.UnitOfWork()) {
                var categories = uow.Categories.ToDictionary(item => item.CategoryName, StringComparer.OrdinalIgnoreCase);
                var publishers = uow.Publishers.ToDictionary(item => item.PublisherName, StringComparer.OrdinalIgnoreCase);

                foreach (var categoryName in list.Where(item => !string.IsNullOrWhiteSpace(item.Binding)).Select(item => item.Binding).ToList().Distinct()) {
                    Category category = null;
                    if (!categories.TryGetValue(categoryName, out category)) {
                        category = new Category() {
                            CategoryName = categoryName
                        };
                        categories.Add(categoryName, category);
                        uow.Add(category);
                    }
                }

                foreach (var publisherName in list.Where(item => !string.IsNullOrWhiteSpace(item.Publisher)).Select(item => item.Publisher).ToList().Distinct()) {
                    Publisher publisher = null;
                    if (!publishers.TryGetValue(publisherName, out publisher)) {
                        publisher = new Publisher() {
                            PublisherName = publisherName
                        };
                        publishers.Add(publisherName, publisher);
                        uow.Add(publisher);
                    }
                }

                foreach (var sourceProduct in list) {
                    Category category = null;
                    Publisher publisher = null;
                    if (!string.IsNullOrWhiteSpace(sourceProduct.Binding)) {
                        category = categories[sourceProduct.Binding];
                    }
                    if (!string.IsNullOrWhiteSpace(sourceProduct.Publisher)) {
                        publisher = publishers[sourceProduct.Publisher];
                    }
                    if (sourceProduct.PackageDimensions == null) {
                        sourceProduct.PackageDimensions = new Dimension();
                    }
                    var product = new Product() {
                        Asin = sourceProduct.ASIN,
                        BuyItNowPrice = sourceProduct.BuyItNowPrice,
                        Category = category,
                        EsrbAgeRating = sourceProduct.ESRBAgeRating,
                        Feature = string.Join(Environment.NewLine, sourceProduct.Feature),
                        Format = sourceProduct.Format,
                        Genre = sourceProduct.Genre.MaxLength(75),
                        HardwarePlatform = sourceProduct.HardwarePlatform.MaxLength(75),
                        Height = sourceProduct.PackageDimensions.Height,
                        LargeImage = sourceProduct.LargeImage,
                        Length = sourceProduct.PackageDimensions.Length,
                        ListPrice = sourceProduct.ListPrice,
                        Manufacturer = sourceProduct.Manufacturer,
                        Model = sourceProduct.Model,
                        PartNumber = sourceProduct.PartNumber,
                        ProductGroup = sourceProduct.ProductGroup,
                        Publisher = publisher,
                        Title = sourceProduct.Title.MaxLength(250),
                        Weight = sourceProduct.PackageDimensions.Weight,
                        Width = sourceProduct.PackageDimensions.Width
                    };
                    uow.Add(product);
                }

                var sw = new Stopwatch();
                sw.Start();

                uow.SaveChanges();

                sw.Stop();

                Console.WriteLine(sw.ElapsedMilliseconds);
                Console.ReadLine();
            }
        }


    }

    public static class ExtensionMethods {
        public static string MaxLength(this string value, int max) {
            if (value != null && value.Length > max)
                return value.Substring(0, max);
            return value;
        }
    }
}
