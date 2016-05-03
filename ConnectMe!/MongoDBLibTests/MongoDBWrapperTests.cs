using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBLib.Tests
{
    [TestClass()]
    public class MongoDBWrapperTests
    {
        MongoDBWrapper wrapper = new MongoDBLib.MongoDBWrapper();

        [TestMethod()]
        public void InsertProfileTest()
        {
            if (wrapper.InsertProfile("UnitTestBenutzer", "UnitTestPasswort") == true)
            {

            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InsertFirmenTest()
        {
            if (wrapper.InsertFirmen("UnitTestLeistungen", "123456789", "UnitTest", "UnitTestStrasse", "UnitTestOrt", "1234") == true)
            {

            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InsertVeranstaltungenTest()
        {
            if (wrapper.InsertVeranstaltungen("UnitTestStrasse", "UnitTestOrt", "1234", new DateTime(2012, 12, 12, 12, 12, 12), new DateTime(2012, 12, 12, 12, 12, 12), "UnitTestName", "UnitTestBeschreibung") == true)
            {

            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void InsertBeitraegeTest()
        {
            if (wrapper.InsertBeitraege("UnitTestBeitrag","FRE2204161209") == true)
            {

            }
            else
            {
                Assert.Fail();
            }
        }
    }
}