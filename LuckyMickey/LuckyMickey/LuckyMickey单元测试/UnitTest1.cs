using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyMickey单元测试
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int W = 25;
            int Z = 30;
            int H = Arithmetic.Add(W, Z);
            Assert.AreEqual(30, H);
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
