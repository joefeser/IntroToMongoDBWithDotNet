using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Commerce.Data {
    
    public class MongoProductView {

        [BsonId]
        [BsonElement("asin")]
        public string ASIN { get; set; }

        [BsonElement("counter")]
        public int Counter { get; set; }

        [BsonElement("lastView")]
        public DateTime LastView { get; set; }

        [BsonElement("keywords")]
        public List<string> Keywords { get; set; }
    }
}
