using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IskoqiApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 10;
           Iskoqi  un=new Iskoqi('n');
           un.size(n);
        }
    }
}
