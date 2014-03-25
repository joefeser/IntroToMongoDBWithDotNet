using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Commerce.Data {

    public class MongoOrderItem {

        [BsonElement("ASIN")]
        public string ASIN { get; set; }

        [BsonElement("orderedQuantity")]
        public int OrderedQuantity { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("unitPrice")]
        public decimal UnitPrice { get; set; }

    }
}
