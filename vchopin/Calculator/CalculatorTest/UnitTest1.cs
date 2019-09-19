using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Console.WriteLine("开始测试");

            Program.writeToFile("hello 回归测试");
            
            
        }
    }
}
