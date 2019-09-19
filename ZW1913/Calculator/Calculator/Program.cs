using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace Calculator
{
    class Program
    {
        private static string[] op = new string[] { "+", "-", "*", "/" }; // Operation set
        public static void Main(string[] args)
        {
            string question = MakeFormula();
            Console.WriteLine(question);
            string ret = Solve(question);
            Console.WriteLine(ret);
            Console.ReadLine();
        }

    
 public static string MakeFormula()
        {
            StringBuilder build = new StringBuilder();
            int count = (int)(GlobalRandom.NextDouble * 2) + 1; // generate random count
            int start = 0;
            int number1 = (int)(GlobalRandom.NextDouble * 99) + 1;
            build.Append(number1);
            while (start <= count)
            {
                int operation = (int)(GlobalRandom.NextDouble * 3); // generate operator
                int number2 = (int)(GlobalRandom.NextDouble * 99) + 1;
                build.Append(op[operation]).Append(number2);
                start++;
            }
            return build.ToString();
        }

        internal static class GlobalRandom
        {
            private static System.Random randomInstance = null;

            public static double NextDouble
            {
                get
                {
                    if (randomInstance == null)
                        randomInstance = new System.Random();

                    return randomInstance.NextDouble();
                }
            }
        }

      
public static string Solve(string formula)
        {
            Stack<string> tempStack = new Stack<string>(); //Store number or operator
            Stack<char> operatorStack = new Stack<char>(); //Store operator
            int len = formula.Length;
            int k = 0;
            for (int j = -1; j < len - 1; j++)
            {
                char formulaChar = formula[j + 1];
                if (j == len - 2 || formulaChar == '+' || formulaChar == '-' || formulaChar == '/' || formulaChar == '*')
                {
                    if (j == len - 2)
                    {
                        tempStack.Push(formula.Substring(k));
                    }
                    else
                    {
                        if (k < j)
                        {
                            tempStack.Push(formula.Substring(k, (j + 1) - k));
                        }
                        if (operatorStack.Count == 0)
                        {
                            operatorStack.Push(formulaChar); //if operatorStack is empty, store it
                        }
                        else
                        {
                            char stackChar = operatorStack.Peek();
                            if ((stackChar == '+' || stackChar == '-') && (formulaChar == '*' || formulaChar == '/'))
                            {
                                operatorStack.Push(formulaChar);
                            }
                            else
                            {
                                tempStack.Push(operatorStack.Pop().ToString());
                                operatorStack.Push(formulaChar);
                            }
                        }
                    }
                    k = j + 2;
                }
            }
            while (operatorStack.Count > 0)
            { // Append remaining operators
                tempStack.Push(operatorStack.Pop().ToString());
            }
            Stack<string> calcStack = new Stack<string>();
            Stack<string> calcStack2 = new Stack<string>();

            while (tempStack.Count != 0)
            {
                calcStack2.Push(tempStack.Pop());
            }




            foreach (string peekChar in calcStack2)
            { // Reverse traversing of stack
                if (!peekChar.Equals("+") && !peekChar.Equals("-") && !peekChar.Equals("/") && !peekChar.Equals("*"))
                {
                    calcStack.Push(peekChar); // Push number to stack
                }
                else
                {
                    int a1 = 0;
                    int b1 = 0;
                    if (calcStack.Count > 0)
                    {
                        b1 = int.Parse(calcStack.Pop());
                    }
                    if (calcStack.Count > 0)
                    {
                        a1 = int.Parse(calcStack.Pop());
                    }
                    switch (peekChar)
                    {
                        case "+":
                            calcStack.Push((a1 + b1).ToString());
                            break;
                        case "-":
                            calcStack.Push((a1 - b1).ToString());
                            break;
                        case "*":
                            calcStack.Push((a1 * b1).ToString());
                            break;
                        default:
                            calcStack.Push((a1 / b1).ToString());
                            break;
                    }
                }
            }
            return formula + "=" + calcStack.Pop();
        }
    }
}

