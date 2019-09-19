using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FourOperation;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 15, 23, 26, 57, 88, 99 };
            int[] b = { 100, 130, 335, 656, 777, 988 };
            for (int i = 0; i < 6; i++)
            {
                ConstructOperation COP = new ConstructOperation(a[i], b[i]);
                int actual = COP.result.Length;
                int expected = a[i];
                Assert.AreEqual(expected, actual);
                Console.WriteLine("测试通过！");
            }
        }
    }
}
