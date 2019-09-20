using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACC.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CountTest()
        {
            string Test1= "11+22+33";
            string Answer1= "11+22+33=66";
            Assert.AreEqual(Program.Count(Test1), Answer1);
            string Test2 = "110-22-33";
            string Answer2 = "110-22-33=55";
            Assert.AreEqual(Program.Count(Test2), Answer2);
            string Test3 = "11*22*33";
            string Answer3 = "11*22*33=7986";
            Assert.AreEqual(Program.Count(Test3), Answer3);
            string Test4 = "33/11-1";
            string Answer4 = "33/11-1=2";
            Assert.AreEqual(Program.Count(Test4), Answer4);
        }
    }
}