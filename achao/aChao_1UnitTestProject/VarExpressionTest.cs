using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class VarExpressionTest
    {
        [TestMethod]
        public void VarExpressionTest_1()
        {
            VarExpression varExpression_1 = new VarExpression(-1);
            Assert.IsNotNull(varExpression_1);
        }
        [TestMethod]
        public void interpreterTest()
        {
            VarExpression varExpression = new VarExpression(0);
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            int i=varExpression.interpreter(list);
            Assert.AreEqual(1, i);

        }
    }
}
