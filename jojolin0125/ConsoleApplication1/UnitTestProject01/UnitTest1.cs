using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculate cal=new Calculate()
            Assert.IsTrue(Calculate.Method1(10) == 55);
        }
    }
}
