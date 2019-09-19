using Microsoft.VisualStudio.TestTools.UnitTesting;
using phCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phCalculator.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void testTest()
        {
            //test1和2用于测试算数结果是否正确 
            //以及这两个合格题目是否会让test返回true
            string test1 = "25*4-3+50";
            int ans1 = 25 * 4 - 3 + 50;
            Test.test(test1);
            Assert.AreEqual(Test.test_timu, (test1 + "=" + ans1.ToString()));
            Assert.IsTrue(Test.test(test1));

            string test2 = "44*6-5";
            int ans2 = 44 * 6 - 5;
            Test.test(test2);
            Assert.AreEqual(Test.test_timu, (test2 + "=" + ans2.ToString()));
            Assert.IsTrue(Test.test(test2));

            //test3，4,5测试不合格题目是否会让test返回false；
            string test3 = "5/0+6";
            string test4 = "8-61*1+5";
            string test5 = "9/2+9+1";
            Assert.IsFalse(Test.test(test3));
            Assert.IsFalse(Test.test(test4));
            Assert.IsFalse(Test.test(test5));






        }
    }
}