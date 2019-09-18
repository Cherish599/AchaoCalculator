using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = "20+10*5";
            string res = "70";
            string TestRes = Program.Calculate(result);
            Assert.AreEqual(res,TestRes);
        }
    }
}
