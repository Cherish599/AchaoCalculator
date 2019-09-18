using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculatorMakeup g = new CalculatorMakeup(5);
          Assert.AreEqual(CalculatorMakeup.testc(), 5);

        }
    }
}


