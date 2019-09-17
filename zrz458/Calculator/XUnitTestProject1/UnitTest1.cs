using System;
using Xunit;
using Calculator;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculator.Calculator cal = new Calculator.Calculator();

            Queue<string> queue = new Queue<string>();
            StringBuilder sb = new StringBuilder();
            queue.Enqueue("1");
            queue.Enqueue("+");
            queue.Enqueue("2");
            queue.Enqueue("*");
            queue.Enqueue("3");
            queue.Enqueue("+");
            queue.Enqueue("4");
            queue.Enqueue("/");
            queue.Enqueue("2");
            Result result = new Result(sb, queue);
            Queue<string> postfixStack = Calculator.Calculator.changeToPostfix(result.FormulaQueue);
            result.setResult(Calculator.Calculator.calculate(postfixStack));
            Assert.Equal(9, result.getResult());
        }
    }
}
