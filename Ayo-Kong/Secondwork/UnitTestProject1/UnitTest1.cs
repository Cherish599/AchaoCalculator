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
            //测试运算结果是否正确
            string a = "10+5/5*4";
            string b = "10+5/5*4=14";
            string c = ConsoleApp1.Inputs.R(a);
            Assert.AreEqual(b, c);
       
        }
    }
}
