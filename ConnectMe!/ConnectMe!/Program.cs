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

            var InsertFirmen = wrapper.InsertFirmen("Fensterscheiben putzen","066413456789","Putzen schnell und gruendlich","Putzstrasse","Putzort","1111");

           



            Console.WriteLine("Press ENTER to exit application");
            Console.ReadLine();
        }
    }
}
