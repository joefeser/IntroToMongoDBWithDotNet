using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Commerce.Data {

    public static class Collections {

        static Collections() {
            //put in here anything that needs to be ignored.
            BsonClassMap.RegisterClassMap<MongoProduct>(cm => {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.UnmapProperty(c => c.BuyItNowPrice);
                cm.GetMemberMap(c => c.Format).SetIgnoreIfNull(true);
                cm.GetMemberMap(c => c.Genre).SetIgnoreIfNull(true);
            });

            BsonClassMap.RegisterClassMap<Dimension>(cm => {
                cm.AutoMap();
                cm.GetMemberMap(c => c.Height).SetSerializer(new DecimalSerializer()).SetElementName("height");
                cm.GetMemberMap(c => c.Length).SetSerializer(new DecimalSerializer()).SetElementName("length");
                cm.GetMemberMap(c => c.Weight).SetSerializer(new DecimalSerializer()).SetElementName("weight");
                cm.GetMemberMap(c => c.Width).SetSerializer(new DecimalSerializer()).SetElementName("width");
            });

            BsonClassMap.RegisterClassMap<MongoOrder>(cm => {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                //cm.Conventions.SetSerializationOptionsConvention(new TypeRepresentationSerializationOptionsConvention(typeof(Guid), BsonType.String));
                //cm.ConventionPack.Conventions.SetSerializationOptionsConvention(new TypeRepresentationSerializationOptionsConvention(typeof(Guid), BsonType.String));
                cm.GetMemberMap(c => c.OrderTotal).SetSerializer(new DecimalSerializer());
            });

            BsonClassMap.RegisterClassMap<MongoOrderItem>(cm => {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
                cm.GetMemberMap(c => c.UnitPrice).SetSerializer(new DecimalSerializer());
            });

            BsonClassMap.RegisterClassMap<MongoProductView>(cm => {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });

            //var myConventions = new ConventionProfile();
            //myConventions.SetSerializationOptionsConvention(
            //    new TypeRepresentationSerializationOptionsConvention(typeof(Guid), BsonType.String));

            ////ConventionRegistry.Register()
            //BsonClassMap.RegisterConventions(myConventions, t => t == typeof(MongoOrder));
        }

        public static MongoCollection<MongoCustomer> CustomerCollection = Mongo.MainDatabase.GetCollection<MongoCustomer>("customer");
        public static MongoCollection<MongoOrder> OrderCollection = Mongo.MainDatabase.GetCollection<MongoOrder>("order");

        public static MongoCollection<MongoProduct> ProductCollection = Mongo.MainDatabase.GetCollection<MongoProduct>("product");
        public static MongoCollection<MongoProductView> ProductViewCollection = Mongo.MainDatabase.GetCollection<MongoProductView>("productview");
    }
}
