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
    public class chooseTests
    {
        [TestMethod()]
        public void ChooseTest()
        {
            int a = choose.Choose("*");
            Assert.AreEqual("1",Convert.ToString(a));
        }
    }
}