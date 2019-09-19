using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int H = 10;
            int F = 20;
            int K = Arithmetic.Add(H, F);
            Assert.AreEqual(30, K);
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
