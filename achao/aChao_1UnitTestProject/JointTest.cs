using Microsoft.VisualStudio.TestTools.UnitTesting;
using aChao_1;
using System.Collections.Generic;
using System.Linq;

namespace aChao_1UnitTestProject
{
    [TestClass]
    public class JointTest
    {
        [TestMethod]
        public void craeteEqualTest()
        {
            Joint joint = new Joint();
            List<string> list = joint.craeteEqual(2);
            int count = list.Count();
            Assert.AreEqual(5, count);
        }
    }
}
