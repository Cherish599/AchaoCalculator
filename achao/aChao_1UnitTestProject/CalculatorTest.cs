using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculatorTest_1() {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            Calculator calculator = new Calculator(list);
            Assert.IsNotNull(calculator);
        }
        [TestMethod]
        public void runTest() {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            Calculator calculator = new Calculator(list);
            int i = calculator.run();
            Assert.AreEqual(3, i);
        } 

    }
}
