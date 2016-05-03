using MongoDBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectMe_
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoDBWrapper wrapper = new MongoDBLib.MongoDBWrapper();
            Console.ForegroundColor = ConsoleColor.Cyan;
            var dropfirmen = wrapper.DeleteFirmenCollection();
            var dropprofile = wrapper.DeleteProfileCollection();
            var dropprivate = wrapper.DeletePrivateCollection();
            var dropveranstaltungen = wrapper.DeleteVeranstaltungenCollection();
            var dropbeitraege = wrapper.DeleteBeitraegeCollection();

            Console.ForegroundColor = ConsoleColor.Red;
            var profile0 = wrapper.InsertProfile("max","hallo");
            var profile1 = wrapper.InsertProfile("julia", "hallo");
            var profile2 = wrapper.InsertProfile("chris", "hallo");
            var profile3 = wrapper.InsertProfile("flo", "hallo");
            var profile4 = wrapper.InsertProfile("hans", "hallo");
            var profile5 = wrapper.InsertProfile("stefan", "hallo");
            var profile6 = wrapper.InsertProfile("rene", "hallo");
            var profile7 = wrapper.InsertProfile("robert", "hallo");
            var profile8 = wrapper.InsertProfile("andi", "hallo");
            var profile9 = wrapper.InsertProfile("patrick", "hallo");

            var firmen = wrapper.InsertFirmen("Test", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen1 = wrapper.InsertFirmen("gmba", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen2 = wrapper.InsertFirmen("co", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen3 = wrapper.InsertFirmen("co kg", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen4 = wrapper.InsertFirmen("gmbh co kg", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen5 = wrapper.InsertFirmen("Virtualbox", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen6 = wrapper.InsertFirmen("VMWare", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen7 = wrapper.InsertFirmen("Intel", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen8 = wrapper.InsertFirmen("Apple", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            var firmen9 = wrapper.InsertFirmen("Sony", "123456789", "Wir sind eine Firma", "Testsrasse", "Deutschland", "1223");
            
            var beitrag = wrapper.InsertBeitraege("Test","MO031019951200");
            var beitrag1 = wrapper.InsertBeitraege("Beitrag", "MO031019951200");
            var beitrag2 = wrapper.InsertBeitraege("Facebook", "MO031019951200");
            var beitrag3 = wrapper.InsertBeitraege("Twitter", "MO031019951200");
            var beitrag4 = wrapper.InsertBeitraege("Tumbler", "MO031019951200");
            var beitrag5 = wrapper.InsertBeitraege("Unterricht", "MO031019951200");
            var beitrag6 = wrapper.InsertBeitraege("NoSQL", "MO031019951200");
            var beitrag7 = wrapper.InsertBeitraege("Mitschrift", "MO031019951200");
            var beitrag8 = wrapper.InsertBeitraege("Schularbeit", "MO031019951200");
            var beitrag9 = wrapper.InsertBeitraege("Noten", "MO031019951200");

            var privat = wrapper.InsertPrivate("Johann", "Langer",new DateTime(2013,05,03),"ich bin schüler","Tennis");
            var privat1 = wrapper.InsertPrivate("Hans", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat2 = wrapper.InsertPrivate("Franz", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat3 = wrapper.InsertPrivate("Fritz", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat4 = wrapper.InsertPrivate("Georg", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat5 = wrapper.InsertPrivate("Rudi", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat6 = wrapper.InsertPrivate("Andi", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat7 = wrapper.InsertPrivate("Werner", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat8 = wrapper.InsertPrivate("Johann", "Bürger", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");
            var privat9 = wrapper.InsertPrivate("Manuel", "Langer", new DateTime(2013, 05, 03), "ich bin schüler", "Tennis");

            var veranstaltungen = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04),"Tolles Event","fun fun fun",5);
            var veranstaltungen1 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Großartiges Event", "fun fun fun", 5);
            var veranstaltungen2 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Super Event", "fun fun fun", 4);
            var veranstaltungen3 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Lustiges Event", "fun fun fun", 4);
            var veranstaltungen4 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Bravo Event", "fun fun fun", 3);
            var veranstaltungen5 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Facebook Event", "fun fun fun", 3);
            var veranstaltungen6 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Twitter Event", "fun fun fun", 2);
            var veranstaltungen7 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Hochzeits Event", "fun fun fun", 2);
            var veranstaltungen8 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Schul Event", "fun fun fun", 1);
            var veranstaltungen9 = wrapper.InsertVeranstaltungen("Testsrasse", "Deutschland", "1223", new DateTime(2013, 05, 03), new DateTime(2013, 05, 04), "Uni Event", "fun fun fun", 1);

            Console.ForegroundColor = ConsoleColor.Green;
            var searchbevor = wrapper.SearchProfileName("max");
            var updatename = wrapper.EditProfileName("max","UMBENANNT");
            var searchnachher = wrapper.SearchProfileName("max");

            var searchevent = wrapper.SearchVeranstaltungenName("Facebook Event");
            var searchprofile = wrapper.SearchProfileName("UMBENANNT");
            
            


            Console.WriteLine("Press ENTER to exit application");
            Console.ReadLine();
        }
    }
}
