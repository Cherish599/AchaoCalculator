using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class symbolTests
    {
        [TestMethod()]
        public void randSymbolTest()
        {
            symbol sym = new symbol();
            Assert.AreEqual(sym.randSymbol(2), "-");
        }
    }
}