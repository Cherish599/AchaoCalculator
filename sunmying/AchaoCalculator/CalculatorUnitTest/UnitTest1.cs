using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AchaoCalculator;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SolveTest()
        //Solve函数测试
        { 
            string msg1 = "53+24-45";
            string correctAns = "53+24-45=32";
            string ans = Program.Solve(msg1);
            Assert.AreEqual(correctAns,ans);
        }
    }
}