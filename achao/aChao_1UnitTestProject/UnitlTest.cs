using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;
namespace aChao_1UnitTestProject
{
    [TestClass]
    public class UnitlTest1
    {
        [TestMethod]
        public void delMulAndDivTests()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            Unitl unitl = new Unitl();
            List<string> list_1 = unitl.delMulAndDiv(list);
            Assert.AreEqual(list,list_1);
        }
        [TestMethod]
        public void writeTxtTests()
        {
            List<string> list = new List<string>();
            list.Add("1");
            list.Add("+");
            list.Add("3");
            list.Add("-");
            list.Add("1");
            Unitl unitl = new Unitl();
            int i = unitl.writeTxt(list);
            Assert.AreEqual(1, i);
        }
    }
}
