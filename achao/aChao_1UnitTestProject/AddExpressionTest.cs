using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using aChao_1;

namespace aChao_1UnitTestProject
{
    [TestClass]
    class AddExpressionTest
    {
        [TestMethod]
        public void AddExpressionTest_1()
        {
            AddExpression addExpression = new AddExpression(new VarExpression(1), new VarExpression(2));
            Assert.IsNotNull(addExpression);
        }
        [TestMethod]
        public void interpreterTest()
        {
            AddExpression addExpression = new AddExpression(new VarExpression(0), new VarExpression(2));
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            int i = addExpression.interpreter(list);
            Assert.AreEqual(4, i);

        }
    }
}
