using System;
using zlllll;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            zlllll.Compute Compute = new Compute("4+4-2*2");
            string res = Compute.run().ToString();
            StringAssert.Contains("4", res);
        }
    }
}
