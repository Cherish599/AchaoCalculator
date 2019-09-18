using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests {
    [TestClass()]
    public class ComputeTests {
        [TestMethod()]
        public void OperateTest() {
            Compute cp = new Compute();
            double a = cp.Operate(1, 2, '+');
            Assert.AreEqual(3, a);
        }
    }
}