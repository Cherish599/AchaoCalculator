using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod]
        public void CalculateTest()
        {
            // 4/2*3+12
            Stack testOps1 = new Stack();
            Stack testNums1 = new Stack();
            testOps1.Push(new Add());
            testOps1.Push(new Mul());
            testOps1.Push(new Div());
            testNums1.Push(12);
            testNums1.Push(3);
            testNums1.Push(2);
            testNums1.Push(4);
            int expected = 18;
            int actual = Program.Calculate(testOps1, testNums1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void toStringTest()
        {
            // 4/2*3+12=18
            Stack testOps1 = new Stack();
            Stack testNums1 = new Stack();
            testOps1.Push(new Add());
            testOps1.Push(new Mul());
            testOps1.Push(new Div());
            testNums1.Push(12);
            testNums1.Push(3);
            testNums1.Push(2);
            testNums1.Push(4);
            int result = 18;
            string expected = "4/2*3+12=18";
            string actual = Program.toString(testOps1, testNums1, result);
            Assert.AreEqual(expected, actual);
        }
    }
}