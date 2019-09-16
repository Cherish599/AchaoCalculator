using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 四则运算计算器
/// 
/// @author Rongze Zhao
/// @date 2019-09-15 22:36
/// </summary>
namespace Calculator
{
    public class Calculator
    {
        private static string[] op = new string[] { "+", "-", "*", "/" };

        /// <summary>
        /// 表达式整数范围 1~n </summary>
        private static int maxNum = 5;
        /// <summary>
        /// 表达式整数个数 1~n </summary>
        private static int maxNumCount = 4;
        private static Random random = new Random();

        /// <summary>
        /// 优先级判断器
        /// </summary>
        /// <param name="c"> 符号 </param>
        /// <returns> "+","-"     1
        ///         "*","/"     2
        ///         other      -1 </returns>
        internal static int precedence(string c)
        {
            switch (c)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            for (int i = 0; i < 10000000; i++) {
                Result result = formulaMaker();
                Queue<string> postfixQueue = changeToPostfix(result.FormulaQueue);
                int res = calculate(postfixQueue);
                Console.WriteLine("formula:" + result.infixFormula);
                Console.WriteLine("result:" + res);
            }
        }

        /// <summary>
        /// 测试函数
        /// 
        /// 用于JavaScript eval函数调用测试
        /// </summary>
        public static Result test()
        {
            Result result = formulaMaker();
            Queue<string> postfixStack = changeToPostfix(result.FormulaQueue);
            result.setResult(calculate(postfixStack));
            return result;
        }


        /// <summary>
        /// 表达式生成器
        /// </summary>
        /// <returns> 中缀表达式队列 </returns>
        public static Result formulaMaker()
        {
            Queue<string> queue = new Queue<string>();
            StringBuilder sb = new StringBuilder();
            int num;
            for (int i = maxNumCount - 1; i > 0; i--)
            {
                num = random.Next(maxNum) + 1;
                string option = op[random.Next(3)];
                queue.Enqueue(num.ToString());
                queue.Enqueue(option);
                sb.Append(num).Append(option);
            }
            num = random.Next(maxNum) + 1;
            queue.Enqueue(num.ToString());
            sb.Append(num);
            return new Result(sb, queue);
        }

        /// <summary>
        /// 中缀表达式转后缀表达
        /// </summary>
        /// <param name="queue"> 中缀表达式队列 </param>
        /// <returns> 后缀表达式队列 </returns>
        public static Queue<string> changeToPostfix(Queue<string> queue)
        {
            Queue<string> queue2 = new Queue<string>(); // 保存操作数
            Stack<string> stack2 = new Stack<string>(); // 保存操作符
            while (queue.Count > 0)
            {
                string symbol = queue.Dequeue();
                if (precedence(symbol) > 0)
                { //检查symbol是否是一个操作数
                    while (stack2.Count > 0 && precedence(stack2.Peek()) >= precedence(symbol))
                    {
                        queue2.Enqueue(stack2.Pop());
                    }
                    stack2.Push(symbol);
                }
                else
                { //symbol 不是一个操作数
                    queue2.Enqueue(symbol);
                }
            }
            while (stack2.Count > 0)
            {
                queue2.Enqueue(stack2.Pop());
            }
            return queue2;
        }

        /// <summary>
        /// 计算函数
        /// 用于计算后缀表达式的值
        /// </summary>
        /// <param name="queue"> 后缀表达式堆栈 </param>
        /// <returns> 计算结果 </returns>
        public static int calculate(Queue<string> queue)
        {
            Stack<string> stack1 = new Stack<string>(); // 保存操作数
            Stack<string> stack2 = new Stack<string>(); // 保存操作符
            foreach (string symbol in queue)
            {
                if (!symbol.Equals("+") && !symbol.Equals("-") && !symbol.Equals("/") && !symbol.Equals("*"))
                {
                    stack1.Push(symbol);
                }
                else
                {
                    int a = int.Parse(stack1.Pop()), b = int.Parse(stack1.Pop());
                    switch (symbol)
                    {
                        case "+":
                            stack1.Push((a + b).ToString());
                            break;
                        case "-":
                            stack1.Push((b - a).ToString());
                            break;
                        case "*":
                            stack1.Push((a * b).ToString());
                            break;
                        default:
                            stack1.Push((a / b).ToString());
                            break;
                    }
                }
            }
            return int.Parse(stack1.Pop());
        }

        /// <summary>
        /// 程序关键数据封装类
        /// 用于输出和测试
        /// </summary>
        public class Result
        {
            /// <summary>
            /// 前缀表达式字符串 </summary>
            internal StringBuilder infixFormula;
            /// <summary>
            /// 后缀表达式队列 </summary>
            internal Queue<string> formulaQueue;

            /// <summary>
            /// 计算结果 </summary>
            internal int result;

            public Result()
            {
            }

            public Result(StringBuilder stringBuilder, Queue<string> formulaQueue)
            {
                this.infixFormula = stringBuilder;
                this.formulaQueue = formulaQueue;
            }

            public virtual StringBuilder StringBuilder
            {
                get
                {
                    return infixFormula;
                }
                set
                {
                    this.infixFormula = value;
                }
            }


            public virtual Queue<string> FormulaQueue
            {
                get
                {
                    return formulaQueue;
                }
                set
                {
                    this.formulaQueue = value;
                }
            }


            public virtual int getResult()
            {
                return result;
            }

            public virtual void setResult(int result)
            {
                this.result = result;
            }
        }

    }
}
