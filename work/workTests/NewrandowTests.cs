using Microsoft.VisualStudio.TestTools.UnitTesting;
using work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work.Tests
{
    [TestClass()]
    public class NewrandowTests
    {
        Newrandow n = new Newrandow();
        [TestMethod()]
        public void RandIntTest()
        {
            int a = n.RandInt();
            Assert.IsTrue(a>=1&&a<100);
        }

        [TestMethod()]
        public void RandSymbolTest()
        {
            int b = n.Randm();
            Assert.IsTrue(b>=2&&b<3);
        }

        [TestMethod()]
        public void RandmTest()
        {
            string c = n.RandSymbol();
            Assert.IsTrue(c=="*"||c=="/"||c=="+"||c=="-");
        }
    }
}