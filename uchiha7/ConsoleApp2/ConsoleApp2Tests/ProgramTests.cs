using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void InspectionTest()
        {
            string str = "64+71-50=85";

            Assert.AreEqual(str,Program.Inspection("64+71-50"));
        }
    }
}