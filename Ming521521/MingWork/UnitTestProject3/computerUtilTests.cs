using Microsoft.VisualStudio.TestTools.UnitTesting;
using MingWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingWork.Tests
{
    [TestClass()]
    public class computerUtilTests
    {
        [TestMethod()]
        public void judgenumberTest()
        {
            Assert.AreEqual(true,computerUtil.judgenumber("2"));
        }

        [TestMethod()]
        public void juderoperTest()
        {
            Assert.AreEqual(true,computerUtil.juderoper("+"));
        }

        [TestMethod()]
        public void addTest()
        {
            Assert.AreEqual(computerUtil.add(2, 3), 5);
        }

        [TestMethod()]
        public void subTest()
        {
            Assert.AreEqual(computerUtil.sub(2, 3), 1);
        }

        [TestMethod()]
        public void mulTest()
        {
            Assert.AreEqual(computerUtil.mul(2, 3), 6);
        }

        [TestMethod()]
        public void divTest()
        {
            Assert.AreEqual(computerUtil.div(2, 4), 2);
        }
        [TestMethod()]
        public void operateTest()
        {
            Assert.AreEqual(computerUtil.operate("*","2","3"), 6);
        }
    }
}