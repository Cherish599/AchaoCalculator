using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CalculateTest()
        {
            string formulate = "7*7-9";
            string ret = "40";
            string ans = Program.Calculate(formulate);
            Assert.AreEqual(ret, ans);
        }
    }
}