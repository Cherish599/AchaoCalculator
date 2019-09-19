using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string formula = "32/8+7";
            string result = "11";
            string Test_result = Program.Calculate(formula);
            Assert.AreEqual(result, Test_result);
        }
    }
}
