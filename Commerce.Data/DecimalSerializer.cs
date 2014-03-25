using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;

namespace Commerce.Data {

    public class DecimalSerializer : IBsonSerializer {
        public object Deserialize(BsonReader bsonReader, Type nominalType, Type actualType, IBsonSerializationOptions options) {
            return ((decimal)bsonReader.ReadInt64()) / 10000;
        }

        public object Deserialize(BsonReader bsonReader, Type nominalType, IBsonSerializationOptions options) {
            return ((decimal)bsonReader.ReadInt64()) / 10000;
        }

        public IBsonSerializationOptions GetDefaultSerializationOptions() {
            return null;
        }

        public void Serialize(BsonWriter bsonWriter, Type nominalType, object value, IBsonSerializationOptions options) {
            if (value is decimal) {
                bsonWriter.WriteInt64((long)((decimal)value * 10000));
            }
        }
    }
}
