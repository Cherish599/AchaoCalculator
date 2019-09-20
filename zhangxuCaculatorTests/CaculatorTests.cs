using Microsoft.VisualStudio.TestTools.UnitTesting;
using zhangxu_Caculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhangxu_Caculator.Tests
{
    [TestClass()]
    public class CaculatorTests
    {
        [TestMethod()]
        public void ProfuncTest()
        {
            Assert.AreEqual(Caculator.symbol[1], '-');
        }
    }
}