using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MakeFormulaTest()
        {
            string makeformula = Program.MakeFormula();
            Assert.IsTrue(makeformula != null);
        }

        [TestMethod()]
        public void CalculateTest()
        {
            string result = "5*4-2";
            string Answer = "5*4-2=18";
            string An = Program.Calculate(result);
            Assert.AreEqual(Answer, An);
        }

       [TestMethod()]
        public void OperatorTest()
        {
            int n = 1;
            string correctOp = "-";
            string op = Program.Operator(n);

            Assert.AreEqual(correctOp, op);
        }
        
       
    }
}