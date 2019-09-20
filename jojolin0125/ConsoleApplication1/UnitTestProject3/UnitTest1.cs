using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = Program.Calculate(12, 24, "+");
            Assert.IsTrue(num == 36);

        }
    }
}
