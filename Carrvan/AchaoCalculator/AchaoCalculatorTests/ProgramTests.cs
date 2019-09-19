using Microsoft.VisualStudio.TestTools.UnitTesting;
using AchaoCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchaoCalculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CountResultTest()
        {
            int[] count = { 1, 2, 3, 3 };
            int[] b = { 1, 3, 4 };
            int o = 3;
            Assert.IsTrue(AchaoCalculator.Program.CountResult(count,b,o)==3);
        }
    }
}