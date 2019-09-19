using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HUOXUFAXIANTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FH f = new FH();
            int a=1;
            int actual = FH.fuhao();
            char excepted = "+";
            Assert.AreEqual(expected,actual,"输出不正确");
        }
    }
}
