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
        public Boolean DeleteFirmenCollection()
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("firmen");
                var filter = new BsonDocument();
                var result = collection.DeleteManyAsync(filter);
                Console.WriteLine("Erfolgreich! Delete von Collection Firmen");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean DeleteBeitraegeCollection()
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("beitraege");
                var filter = new BsonDocument();
                var result = collection.DeleteManyAsync(filter);
                Console.WriteLine("Erfolgreich! Delete von Collection beitraege");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean DeletePrivateCollection()
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("privat");
                var filter = new BsonDocument();
                var result = collection.DeleteManyAsync(filter);
                Console.WriteLine("Erfolgreich! Delete von Collection Privat");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean DeleteProfileCollection()
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("profil");
                var filter = new BsonDocument();
                var result = collection.DeleteManyAsync(filter);
                Console.WriteLine("Erfolgreich! Delete von Collection Profil");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean DeleteVeranstaltungenCollection()
        {
            try
            {
                var collection = db.GetCollection<BsonDocument>("veranstalltungen");
                var filter = new BsonDocument();
                var result = collection.DeleteManyAsync(filter);
                Console.WriteLine("Erfolgreich! Delete von Collection Veranstalltungen");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public long GetProfileCount()
        {
            var filter = new BsonDocument();
            var result = this.db.GetCollection<BsonDocument>("profile").Count(filter);
            return result;
        }
        public long GetVeranstalltungenCount()
        {
            var filter = new BsonDocument();
            var result = this.db.GetCollection<BsonDocument>("veranstalltungen").Count(filter);
            return result;
        }
        public long GetBeitraegeCount()
        {
            var filter = new BsonDocument();
            var result = this.db.GetCollection<BsonDocument>("beitraege").Count(filter);
            return result;
        }
        public long GetPrivateCount()
        {
            var filter = new BsonDocument();
            var result = this.db.GetCollection<BsonDocument>("private").Count(filter);
            return result;
        }
        public long GetFirmenCount()
        {
            var filter = new BsonDocument();
            var result = this.db.GetCollection<BsonDocument>("firmen").Count(filter);
            return result;
        }

        public IList<string> GetProfileNames()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("profile")
              .Find(filter).ToList()
              .Select(o => o.GetValue("benutzername").AsString).ToList();

            return result;
        }
        public IList<string> GetPrivateFirstnames()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("private")
              .Find(filter).ToList()
              .Select(o => o.GetValue("vorname").AsString).ToList();

            return result;
        }
        public IList<string> GetPrivateLastnames()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("private")
              .Find(filter).ToList()
              .Select(o => o.GetValue("nachname").AsString).ToList();

            return result;
        }
        public IList<string> GetPrivateBirthday()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("private")
              .Find(filter).ToList()
              .Select(o => o.GetValue("geburtsdatum").AsString).ToList();

            return result;
        }
        public IList<string> GetPrivateAboutme()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("private")
              .Find(filter).ToList()
              .Select(o => o.GetValue("ueber mich").AsString).ToList();

            return result;
        }
        public IList<string> GetPrivateHobby()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("private")
              .Find(filter).ToList()
              .Select(o => o.GetValue("interessen").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenAchievements()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("achievements").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenTelefon()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("telefon").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenAboutus()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("ueber uns").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenStreet()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("strasse").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenLocation()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("ort").AsString).ToList();

            return result;
        }
        public IList<string> GetFirmenZipcode()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("firmen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("plz").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenStreet()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("strasse").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenLocation()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("ort").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenZipcode()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("plz").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenTime()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("zeit").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenDate()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("datum").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenName()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("name").AsString).ToList();

            return result;
        }
        public IList<string> GetVeranstalltungenDescription()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("veranstalltungen")
              .Find(filter).ToList()
              .Select(o => o.GetValue("beschreibung").AsString).ToList();

            return result;
        }
        public IList<string> GetBeitraegeText()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("beitraege")
              .Find(filter).ToList()
              .Select(o => o.GetValue("text").AsString).ToList();

            return result;
        }
        public IList<string> GetBeitraegeTimestamp()
        {
            var filter = new BsonDocument();
            var result =
              this.db.GetCollection<BsonDocument>("beitraege")
              .Find(filter).ToList()
              .Select(o => o.GetValue("zeitstaempel").AsString).ToList();

            return result;
        }
    }
}
