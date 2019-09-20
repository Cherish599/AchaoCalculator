using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            int  num = Program.Calculate(1, 2, "+");
            Assert.IsTrue(num == 3);
            
        }
    }
}
