using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator.Calculate calculate = new Calculator.Calculate();
            calculate.makeExercises(5);
            Console.WriteLine();
            calculate.makeExercises(3);
        }
    }
}
