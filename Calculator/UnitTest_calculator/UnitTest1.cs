using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest_calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testcalculate()    //计算测试
        {
            string s = "2+6*9-1";       //实际值为55
            string expact = "55";
            string y=Program.calculate(s);
            Assert.AreEqual(expact,y);      //故意测试不成功，方便后面回归测试
        }

        [TestMethod]
        public void Testnotnull()          //测试是否为空
        {
            string s = "2+6*9-1";       
            string y = Program.calculate(s);
            Assert.IsNotNull(y);      
        }
    }
}
