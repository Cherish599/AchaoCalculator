using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcuUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] testarry_a = new int[] { 10, 15, 20 };
            char[] testarry_b = new char[] { '+', '*' };
            calcu cal_to = new calcu(testarry_a, testarry_b);
            cal_to.
            Assert.AreEqual(310,)
        }
    }
}
