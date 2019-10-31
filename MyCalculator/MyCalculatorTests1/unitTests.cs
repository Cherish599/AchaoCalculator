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
        public void SolveTest()
        {
            Assert.IsTrue(Calculator.Solve("2+40/2*1") == 22.ToString()) ;
        }
    }
}