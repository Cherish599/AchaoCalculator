using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            string res = "3*3-4";
            string aws = "5";
            Assert.AreEqual(Calculator.Solve(res),aws);
        }
    }
}