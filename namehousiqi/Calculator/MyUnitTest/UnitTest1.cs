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
            calculate.makeExercises(1000);
            Console.WriteLine();
            calculate.makeExercises(30);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Calculator.Calculate calculate = new Calculator.Calculate();
            calculate.makeExercises(0);
            Console.WriteLine();
            calculate.makeExercises(1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Calculator.Calculate calculate = new Calculator.Calculate();
            calculate.makeExercises(500);        
        }
        [TestMethod]
        public void TestMethod4()
        {
            Calculator.Calculate calculate = new Calculator.Calculate();
            calculate.makeExercises(-1);
            calculate.makeExercises(-200);
            calculate.makeExercises(100);
        }
    }
}
