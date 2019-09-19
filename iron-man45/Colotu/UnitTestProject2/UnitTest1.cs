using Microsoft.VisualStudio.TestTools.UnitTesting;
using Colotu;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //测试计算结果的方法
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 2, 2, 2, 2 };
            method mtd = new method();
            Assert.AreEqual(mtd.Result(a,b,4),120);
           
        }
    }
}
