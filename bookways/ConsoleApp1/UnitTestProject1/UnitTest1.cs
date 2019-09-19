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
            int a = 10;
            int b = 20;
            int c = Arithmetic.Add(a, b);
            Assert.AreEqual(30, c);



        }
        public class Arithmetic
        {
            public static int Add(int nb1, int nb2)
            {
                return nb1 + nb2;
            }
        }
    }
}
