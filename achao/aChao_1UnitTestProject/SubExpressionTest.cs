using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class SubExpressionTest
    {
        [TestMethod]
        public void SubExpressionTest_1()
        {
            SubExpression subExpression = new SubExpression(new VarExpression(1),new VarExpression(2));
            Assert.IsNotNull(subExpression);
        }
        [TestMethod]
        public void interpreterTest()
        {
            SubExpression subExpression = new SubExpression(new VarExpression(0), new VarExpression(2)); List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            int i = subExpression.interpreter(list);
            Assert.AreEqual(-2, i);

        }
    }
}
