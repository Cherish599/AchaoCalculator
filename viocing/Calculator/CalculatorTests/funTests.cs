using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class funTests
    {

        [TestMethod()]
        public void cvTest1()
        {
            fun f = new fun();
            string s = "2+3*5-9";
            string rt = "2+3*5-9=8";
            string u = f.cv(s);
            Assert.AreEqual(rt, u);
        }
    }
}