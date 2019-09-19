using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void makequestionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SolveTest()
        {
            Program p = new Program();
            string a = "8*7+1*6-5";
            string ret = p.Solve(a);
            Assert.AreEqual(ret, (string)"11+22=33");
        }
    }
}