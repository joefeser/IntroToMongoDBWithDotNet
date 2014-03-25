using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Commerce.Data {

    public class MongoProduct {

        [BsonId]
        [BsonElement("asin")]
        public string ASIN {
            get;
            set;
        }

        [BsonElement("binding")]
        public string Binding {
            get;
            set;
        }

        [BsonElement("buyPrice")]
        public int BuyItNowPriceInteger {
            get {
                return (int)(BuyItNowPrice * 10000); //4 dec places
            }
            set {
                BuyItNowPrice = value / 10000;
            }
        }

        //Set in map
        //[BsonIgnore]
        public decimal BuyItNowPrice {
            get;
            set;
        }

        [BsonIgnoreIfNull]
        [BsonElement("esrb")]
        public string ESRBAgeRating {
            get;
            set;
        }

        //also ShortDescription
        [BsonElement("feature")]
        public List<string> Feature {
            get;
            set;
        }

        [BsonElement("format")]
        public string Format {
            get;
            set;
        }

        [BsonElement("genre")]
        public string Genre {
            get;
            set;
        }

        [BsonElement("platform")]
        public string HardwarePlatform {
            get;
            set;
        }

        [BsonElement("image")]
        public string LargeImage {
            get;
            set;
        }

        [BsonElement("listPrice")]
        public int ListPriceInteger {
            get {
                return (int)(ListPrice * 10000); //4 dec places
            }
            set {
                ListPrice = value / 10000;
            }
        }

        //MSRP
        [BsonIgnore]
        public decimal ListPrice {
            get;
            set;
        }

        [BsonElement("mfr")]
        public string Manufacturer {
            get;
            set;
        }

        [BsonElement("model")]
        public string Model {
            get;
            set;
        }

        [BsonElement("dimensions")]
        public Dimension PackageDimensions {
            get;
            set;
        }

        [BsonElement("partNumber")]
        public string PartNumber {
            get;
            set;
        }

        [BsonElement("group")]
        public string ProductGroup {
            get;
            set;
        }

        [BsonElement("publisher")]
        public string Publisher {
            get;
            set;
        }

        [BsonElement("title")]
        public string Title {
            get;
            set;
        }

    }
}
