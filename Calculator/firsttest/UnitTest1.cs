using Calculator;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void OptionTest()
        {
            choicemath cho = new choicemath();
            int test = cho.Option(1, "+", 2);
            Assert.AreEqual(test , 3);
           
        }
    }
}

namespace firsttest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
