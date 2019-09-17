using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10, b = 15;
            int c = Calc.ADD(a, b);
            Assert.AreEqual(25, c);

        }
        public class Calc
        {
            public static int ADD(int a, int b)
            {
                return a + b;
            }
        }
    }
}
