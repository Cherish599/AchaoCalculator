using System;
using System.Collections.Generic;
using System.Linq;

namespace aChao_1
{
    public class Calculator
    {
        private Expression expression;
        private List<string> equalString;
        public Calculator(List<string> equalString)
        {
            this.equalString = equalString;
            Stack<Expression> stack = new Stack<Expression>();
            Expression left = null;
            Expression right = null;
            Unitl unitl = new Unitl();
            equalString = unitl.delMulAndDiv(equalString);
            Console.WriteLine(string.Join("", equalString.ToArray()));
            for (int i = 0; i < equalString.Count(); i++)
            {
                switch (equalString[i])
                {
                    case "+":
                        left = stack.Pop();
                        right = new VarExpression(++i);
                        stack.Push(new AddExpression(left, right));
                        break;
                    case "-":
                        left = stack.Pop();
                        right = new VarExpression(++i);
                        stack.Push(new SubExpression(left, right));
                        break;
                    case "*":
                        left = stack.Pop();
                        right = new VarExpression(++i);
                        stack.Push(new MulExpression(left, right));
                        break;
                    case "/":
                        left = stack.Pop();
                        right = new VarExpression(++i);
                        stack.Push(new DivExpression(left, right));
                        break;
                    default:
                        stack.Push(new VarExpression(i));
                        break;
                }
            }
            this.expression = stack.Pop();
        }

        public int run()
        {
            return this.expression.interpreter(equalString);
        }
    }
}
