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
    public class SplitTests
    {
        Split s = new Split();
        [TestMethod()]
        public void SplitsTest()
        {
            List<string> l = s.Splits();
            Assert.IsNotNull(l);
        }
    }
}