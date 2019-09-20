using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "16*3+2*1=50";
            writeFile file = new writeFile();
            file.writefile(str);
            string txt = System.IO.File.ReadAllText(@"e:\\test.txt");
            Assert.IsTrue(txt == str);
        }
    }
}
