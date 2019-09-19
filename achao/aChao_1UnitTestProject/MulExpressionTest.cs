using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class MulExpressionTest
    {
        [TestMethod]
        public void MulExpressionTest_1()
        {
            MulExpression mulExpression = new MulExpression(new VarExpression(1), new VarExpression(2));
            Assert.IsNotNull(mulExpression);
        }
        [TestMethod]
        public void interpreterTest()
        {
            MulExpression mulExpression = new MulExpression(new VarExpression(0), new VarExpression(2));
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            int i = mulExpression.interpreter(list);
            Assert.AreEqual(3, i);

        }
    }
}
