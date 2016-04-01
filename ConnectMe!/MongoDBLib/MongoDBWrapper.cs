using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBLib
{
   public class MongoDBWrapper
    {
        private IMongoClient client;
        private IMongoDatabase db;

        public MongoDBWrapper()
        {
            var settings = new MongoClientSettings()
            {
                Server = new MongoServerAddress(
                 Properties.Settings.Default.MongoDBHost,
                 Properties.Settings.Default.MongoDBPort)
            };

            this.client = new MongoClient(settings);
            this.db = client.GetDatabase(
              Properties.Settings.Default.MongoDBName);
        }

        public Boolean InsertProfile(String user, String password)
        {
            try
            {
                var document = new BsonDocument
                {
                 { "profile" , new BsonDocument
                     {
                        { "benutzername", user },
                        { "password", password }
                     }
                }
               };

                var collection = db.GetCollection<BsonDocument>("profile");
                collection.InsertOneAsync(document);

                return true;
            }
            catch
            {
                return false;
            }


        }
        public Boolean Delete()
        {
            try
            {

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
