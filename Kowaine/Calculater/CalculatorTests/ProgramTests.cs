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
            int expected1 = 18;
            int actual1 = Program.Calculate(testOps1, testNums1);
            Assert.AreEqual(expected1, actual1);

            //80-76/4-55=6
            Stack testOps2 = new Stack();
            Stack testNums2 = new Stack();
            testOps2.Push(new Sub());
            testOps2.Push(new Div());
            testOps2.Push(new Sub());
            testNums2.Push(55);
            testNums2.Push(4);
            testNums2.Push(76);
            testNums2.Push(80);
            int expected2 = 6;
            int actual2 = Program.Calculate(testOps2, testNums2);
            Assert.AreEqual(expected2, actual2);
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