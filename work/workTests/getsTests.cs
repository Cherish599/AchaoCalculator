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
    public class getsTests
    {
        gets gets = new gets();
        Split split = new Split();
        [TestMethod()]
        public void Gets1Test()
        {
            gets.Gets1(split.Splits());
            Assert.Fail();
        }

        [TestMethod()]
        public void Gets2Test()
        {
            gets.Gets1(split.Splits());
            int a = gets.Gets2();
            Assert.IsNotNull(a);
        }
    }
}