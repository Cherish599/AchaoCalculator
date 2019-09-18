using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTest_calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Testadd()    //加法测试
        {
            int a = 5, b = 6;
            int expact = Program.add(a, b);  
            Assert.AreEqual(expact , 11);

        }

        [TestMethod]
        public void Testsub()    //减法测试
        {
            double a = 3.22,b = 1.12;
            double expact = Program.sub(a, b);
            Assert.AreEqual(expact,2.01);
        }

        [TestMethod]
        public void Testjudge()    //对象结果是否为false测试
        {
            int a = 6, b = 11;
            Boolean expact = Program.judge(a, b);
            Assert.IsFalse(expact);
        }

        [TestMethod]
        public void NotNullTest()    //判断某个对象是否不为null
        {
            Assert.IsNotNull(null);
        }

    }
}
