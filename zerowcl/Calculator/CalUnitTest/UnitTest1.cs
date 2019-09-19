using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace CalUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            
            int res = 3;
            int TestRes = Build .Sum(5,3,5,1,2);//5,3,5为运算数，1,2为运算符
            Assert.AreEqual(res, TestRes);
        }
    }
}
