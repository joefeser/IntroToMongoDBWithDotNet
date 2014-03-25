using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Commerce.Data {

    public static class Mongo {

        public static string connectionString = ConfigurationManager.AppSettings["MongoServer"];
        public static MongoClient Client = new MongoClient(connectionString);
        public static MongoServer Server = Client.GetServer();
        public static MongoDatabase MainDatabase = Server.GetDatabase("commerce");
    }
}
