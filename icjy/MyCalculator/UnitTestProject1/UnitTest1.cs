using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //准备
            MyCal cal = new MyCal();

            //测试
            int total = 3 * 4 - 2;
            String result1 = Convert.ToString(total);
            String result2 = cal.calculate("3*4-2");
            Assert.AreEqual(result2, result1);
            Assert.AreEqual(cal.calculate("10/2+5*5"), Convert.ToString(10 / 2 + 5 * 5));
            Assert.AreEqual(cal.calculate("30+71*6"), Convert.ToString(30 + 71 * 6));
            Assert.AreEqual(cal.calculate("51-12*6+66"), Convert.ToString(51 - 12 * 6 + 66));
            Assert.AreEqual(cal.calculate("71 * 60 - 95 - 65"), Convert.ToString(71 * 60 - 95 - 65));
        }
    }
}
