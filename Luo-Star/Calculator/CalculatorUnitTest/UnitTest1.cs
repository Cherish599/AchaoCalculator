using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string real;
            Symbol a = new Symbol();
            char[] b = new char[] { '+', '-', '*', '/' };
            real = a.GetSymbol();
            if (char.Parse(real) == '+' || char.Parse(real) == '-' || 
                char.Parse(real) == '*' || char.Parse(real) == '/')
            {
                Assert.AreEqual(0,0);
            }
            else
            {
                Assert.AreEqual(1, 0);
            }
        }
    }
}
