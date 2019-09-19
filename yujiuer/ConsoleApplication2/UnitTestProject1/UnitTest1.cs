using System;
using ConsoleApplication2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string formula = "88*2-30";
            string result = "146";
            string Test_result = Program.Calculate(formula);
            Assert.AreEqual(result, Test_result);
        }
    }
}
