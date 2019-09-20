

using System;
using System.Collections;
using System.Collections.Generic;

namespace Yanyixiao
{
    public class Program
    {

        public class Formula
        {
            public string Form { get; internal set; }
            public Queue<string> FormQueue = new Queue<string>();
        }

        public static string[] op = { "+", "-", "*", "/" };// Operation set
        static void Main(string[] args)
        {

            int i;
            System.Console.WriteLine("请输入需要的题目数量：");
            int n = Convert.ToInt32(System.Console.ReadLine());
            for (i = 0; i < n;)
            {
                Formula question = MakeFormula();
                double ret = Solve(question);
                if ((int)ret == ret && ret >= 0)
                {
                    System.Console.Write(question.Form);
                    System.Console.Write("=");
                    System.Console.WriteLine(ret);
                    i++;
                }
            }

        }


        public static Formula MakeFormula()
        {
            Random ran = new Random();
            Formula Form = new Formula();
            string build = null;
            int count = ran.Next(1, 3); // generate random count
            int start = 0;
            int number1 = ran.Next(1, 99);
            build = build + number1;
            Form.FormQueue.Enqueue(Convert.ToString(number1));//uytd 8796r756eu675v 786f876v

            while (start <= count)
            {
                int operation = ran.Next(0, 4); ; // generate operator
                int number2 = ran.Next(1, 99);
                build = build + op[operation] + number2;
                Form.FormQueue.Enqueue(op[operation]);
                Form.FormQueue.Enqueue(Convert.ToString(number2));
                start++;
            }
            Form.Form = build;
            return Form;
        }//Make a Formula(like 1*5+62-5)


        public static double Solve(Formula formula)
        {
            Stack<double> numberStack = new Stack<double>();//Store number
            Stack operatorStack = new Stack();//Store operator
            while (!(formula.FormQueue.Count == 0))
            {
                if (!(formula.FormQueue.Peek() == "+" || formula.FormQueue.Peek() == "-"
                   || formula.FormQueue.Peek() == "*" || formula.FormQueue.Peek() == "/"))//判断是否数字或者operator
                {
                    numberStack.Push(Convert.ToDouble(formula.FormQueue.Dequeue()));
                }
                else
                {

                    double X, Y;
                    switch (formula.FormQueue.Dequeue())
                    {
                        case "*":
                            X = numberStack.Pop();
                            Y = Convert.ToDouble(formula.FormQueue.Dequeue());
                            numberStack.Push(X * Y);
                            goto First;

                        case "/":
                            X = numberStack.Pop();
                            Y = Convert.ToDouble(formula.FormQueue.Dequeue());                                   /////Designed by Yanyixiao
                            numberStack.Push(X / Y);                                                             /////09/18/2019
                            goto First;


                        case "+":
                            operatorStack.Push("+");
                            goto First;

                        case "-":
                            operatorStack.Push("-");
                            goto First;
                    }
                First:;
                }

            }//乘除法计算完毕
            while (numberStack.Count > 1)
            {

                switch (operatorStack.Peek())
                {
                    case "+":
                        numberStack.Push((Convert.ToDouble(numberStack.Pop()) + Convert.ToDouble(numberStack.Pop())));
                        goto Second;

                    case "-":
                        double X, Y;
                        X = Convert.ToDouble(numberStack.Pop());
                        Y = Convert.ToDouble(numberStack.Pop());
                        numberStack.Push(Y - X);
                        goto Second;

                }
            Second:;



            }
            return numberStack.Pop();
        }
    }
}

