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
    public class ExpressionsFactoryTests
    {
        ExpressionsFactory ef = new ExpressionsFactory();
        Random random = new Random(10);
        [TestMethod()]
        public void getOperatorTest()
        {
            string Operators = "+";
            string TestOperator = ef.getOperator(0);
            Assert.AreEqual(Operators,TestOperator);
        }

        [TestMethod()]
        public void getAnExpressionTest()
        {
            string TestExpression = ef.getAnExpression();
            Console.WriteLine(TestExpression);
        }
    }
}