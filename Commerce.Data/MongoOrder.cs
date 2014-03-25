using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Commerce.Data {

    public class MongoOrder {

        private MongoCustomer _customer;
        private MongoCustomer _shipTo;

        public MongoOrder() {
            Details = new List<MongoOrderItem>();
        }

        [BsonId]
        public ObjectId _id {
            get;
            set;
        }

        [BsonElement("customer")]
        public MongoCustomer Customer {
            get {
                return _customer;
            }
            set {
                _customer = value;
                if (value != null) {
                    CustomerId = value.CustomerId;
                }
            }
        }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("customerId")]
        public Guid CustomerId { get; set; }

        [BsonElement("details")]
        public List<MongoOrderItem> Details { get; set; }

        [BsonElement("orderDate")]
        public DateTime OrderDate { get; set; }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("orderId")]
        public Guid OrderId { get; set; }

        [BsonElement("orderTotal")]
        public decimal OrderTotal { get; set; }

        [BsonElement("shipTo")]
        public MongoCustomer ShipTo {
            get {
                return _shipTo;
            }
            set {
                _shipTo = value;
                if (value != null) {
                    ShipToCustomerId = value.CustomerId;
                }
            }
        }

        [BsonRepresentation(BsonType.String)]
        [BsonElement("shipToCustomerId")]
        public Guid ShipToCustomerId { get; set; }

        [BsonElement("status")]
        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus {
        New = 0,
        Processing = 1,
        Shipping = 2,
        Shipped = 3
    }
}
