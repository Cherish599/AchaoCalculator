using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;


namespace aChao_1UnitTestProject
{
    [TestClass]
    public class DivExpressionTest
    {
        [TestMethod]
        public void DivExpressionTest_1()
        {
            DivExpression divExpression = new DivExpression(new VarExpression(1), new VarExpression(2));
            Assert.IsNotNull(divExpression);
        }
        [TestMethod]
        public void interpreterTest()
        {
            DivExpression divExpression = new DivExpression(new VarExpression(0), new VarExpression(2)); List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            int i = divExpression.interpreter(list);
            Assert.AreEqual(0, i);

        }
    }
}
