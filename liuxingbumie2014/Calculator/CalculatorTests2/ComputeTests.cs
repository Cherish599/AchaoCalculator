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
            Compute cm = new Compute();
            double a = cm.Operate(1, 2, '+');
            double b = cm.Operate(1, 2, '-');
            double c = cm.Operate(1, 2, '*');
            double d = cm.Operate(2, 1, '/');
            Assert.AreEqual(3, a);
            Assert.AreEqual(-1, b);
            Assert.AreEqual(2, c);
            Assert.AreEqual(2, d);
        }

        [TestMethod()]
        public void CalculateTest() {
            StringBuilder sb = new StringBuilder("5+6/2*3");
            StringBuilder sd = new StringBuilder("7*5+8/4");
            Compute cm = new Compute(sb);
            cm.DoTrans();
            Compute cn = new Compute(sd);
            cn.DoTrans();
            double a = cm.Calculate();
            double b = cn.Calculate();
            Assert.AreEqual(a,14);
            Assert.AreEqual(b,37);
        }
    }
}