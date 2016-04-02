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
                Console.WriteLine("Profil: "+user+" wurde hinzugefügt.");
                return true;
            }
            catch
            {
                Console.WriteLine("Fehler: Methode-InsertProfile");
                return false;
            }

        }
        public Boolean InsertPrivate(String firstname, String lastname,DateTime birthday,String aboutme,String hobby)
        {
            try
            {
                var document = new BsonDocument
                {
                 { "privat" , new BsonDocument
                     {
                        
                        { "vorname", firstname },
                        { "nachname", lastname },
                        { "geburtsdatum", birthday },
                        { "ueber mich", aboutme },
                        { "interessen", hobby }
                     }
                }
               };

                var collection = db.GetCollection<BsonDocument>("privat");
                collection.InsertOneAsync(document);
                Console.WriteLine("Privat: " + firstname +" "+lastname+ " wurde hinzugefügt.");
                return true;
            }
            catch
            {
                Console.WriteLine("Fehler: Methode-InsertPrivate");
                return false;
            }

        }
        public Boolean InsertFirmen(String achievements, String telefon, String aboutus, String street, String location,String zipcode)
        {
            try
            {
                var document = new BsonDocument
                {
                 { "firmen" , new BsonDocument
                     {

                        { "leistungen", achievements },
                        { "telefon", telefon },
                        { "ueber uns", aboutus },
                        { "straße", street },
                        { "ort", location },
                        { "plz", zipcode }
                     }
                }
               };

                var collection = db.GetCollection<BsonDocument>("firmen");
                collection.InsertOneAsync(document);
                Console.WriteLine("Firmen: " + achievements + " wurde hinzugefügt.");
                return true;
            }
            catch
            {
                Console.WriteLine("Fehler: Methode-InsertFirmen");
                return false;
            }

        }
        public Boolean InsertVeranstaltungen(String street, String location, String plz, DateTime time, DateTime date, String name,String description)
        {
            try
            {
                var document = new BsonDocument
                {
                 { "veranstaltungen" , new BsonDocument
                     {

                        { "straße", street },
                        { "ort", location },
                        { "plz", plz },
                        { "zeit", time },
                        { "datum", date },
                        { "name", name },
                        { "beschreibung",description }
                     }
                }
               };

                var collection = db.GetCollection<BsonDocument>("veranstaltungen");
                collection.InsertOneAsync(document);
                Console.WriteLine("Veranstaltungen: " +name + " wurde hinzugefügt.");
                return true;
            }
            catch
            {
                Console.WriteLine("Fehler: Methode-InsertVeranstaltungen");
                return false;
            }

        }
        public Boolean InsertBeitraege(String text, String timecode)
        {
            try
            {
                var document = new BsonDocument
                {
                 { "beitraege" , new BsonDocument
                     {

                        { "text", text },
                        { "zeitstempel",timecode }
                     }
                }
               };

                var collection = db.GetCollection<BsonDocument>("beitraege");
                collection.InsertOneAsync(document);
                Console.WriteLine("Beitraege: " + text +" "+timecode +" wurde hinzugefügt.");
                return true;
            }
            catch
            {
                Console.WriteLine("Fehler: Methode-InsertBeitraege");
                return false;
            }

        }
        public Boolean DropAllCollection()
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
