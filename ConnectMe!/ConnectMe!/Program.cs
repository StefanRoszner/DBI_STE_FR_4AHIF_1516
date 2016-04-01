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

            var count = wrapper.InsertProfile("Test", "TestPasswort");

            Console.WriteLine(string.Format("Number of restaurant: {0}", count));



            Console.WriteLine("Press ENTER to exit application");
            Console.ReadLine();
        }
    }
}
