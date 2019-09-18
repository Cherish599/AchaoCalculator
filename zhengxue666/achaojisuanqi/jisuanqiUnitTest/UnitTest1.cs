using Microsoft.VisualStudio.TestTools.UnitTesting;
using achaojisuanqi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achaojisuanqi.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void GreatCalculationTest()
        {
            string a = "3*22";
            string b = Program.Calculation(a);
            string c = "3*22=66";
            Assert.AreEqual(b, c);
        }
    }
}
