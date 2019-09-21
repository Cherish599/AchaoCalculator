
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void verifyTest()
        {
            Assert.IsTrue(Calculator.verify("22+5*20") == 122.ToString());
        }
    }
}