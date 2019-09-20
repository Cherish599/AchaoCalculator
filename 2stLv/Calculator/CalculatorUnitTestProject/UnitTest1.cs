using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Calculator.Program.Judge(50));
            //Assert.AreEqual(0, Calculator.Program.Judge(2.5));
            //Assert.AreEqual(0, Calculator.Program.Judge(-1));
        }
    }
}
