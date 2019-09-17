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
        /// 表达式整数范围 1~n
        /// </summary>
        private static int maxNum = 100;
        /// <summary>
        /// 表达式个数（调用multipleFormulaGenerator() 和 additionAndSubtractionFormulaGenerator() 的次数） 1~n
        /// </summary>
        private static int maxNumCount = 3;
        private static Random random = new Random();
        private static Random random2 = new Random(random.Next(1000) + 1000);

        /// <summary>
        /// 优先级判断器
        /// </summary>
        /// <param name="c"> 符号 </param>
        /// <returns> "+","-"     1
        /// "*","/"     2
        /// other      -1 </returns>
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
            Result result = formulaMaker();
            Console.WriteLine("formula:" + result.infixFormula);
            Queue<string> postfixStack = changeToPostfix(result.FormulaQueue);
            int res = calculate(postfixStack);
            Console.WriteLine("result:" + res);
            Console.ReadLine();
        }

        /// <summary>
        /// 表达式生成器
        /// </summary>
        /// <returns> 中缀表达式队列 </returns>
        public static Result formulaMaker()
        {
            Queue<string> queue = new Queue<string>();
            StringBuilder sb = new StringBuilder();
            int maxNumCount2 = maxNumCount;
            while (maxNumCount2-- > 0)
            {
                string option = op[random.Next(2)];
                int nextBoolean = random.Next(0,1);
       
                if (nextBoolean==0)
                {
                    Queue<string> queue1 = multipleFormulaGenerator(random.Next(3) + 1);
                    mergeQueue(queue, queue1);
                }
                else
                {
                    mergeQueue(queue, additionAndSubtractionFormulaGenerator(random2.Next(3) + 1));
                }
                if (maxNumCount2 != 0)
                {
                    queue.Enqueue(op[random.Next(2)]);
                }
            }
            foreach (string s in queue)
            {
                sb.Append(s);
            }
            return new Result(sb, queue);
        }

        /// <summary>
        /// 中缀表达式转后缀表达
        /// </summary>
        /// <param name="queue"> 中缀表达式队列 </param>
        /// <returns> 后缀表达式堆栈 </returns>
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
        /// <param name="stack"> 后缀表达式堆栈 </param>
        /// <returns> 计算结果 </returns>
        public static int calculate(Queue<string> stack)
        {
            Stack<string> stack1 = new Stack<string>(); // 保存操作数
            Stack<string> stack2 = new Stack<string>(); // 保存操作符
            foreach (string symbol in stack)
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
                            stack1.Push((b / a).ToString());
                            break;
                    }
                }
            }
            return int.Parse(stack1.Pop());
        }

        /// <summary>
        /// 给定一个乘除法表达式所含操作数的个数，生成一个随机的乘除法表达式，并以队列的形式返回
        /// </summary>
        /// <param name="count"> 符号数个数 </param>
        /// <returns> 乘除法表达式队列 </returns>
        public static Queue<string> multipleFormulaGenerator(int count)
        {
            Queue<string> queue = new Queue<string>();
            int num = random.Next(maxNum) + 1;
            queue.Enqueue(num.ToString());
            while (--count > 0)
            {
                string option = op[2 + random.Next(2)];
                if (string.ReferenceEquals(option, "/"))
                {
                    int factor = chooseRandomFactor(num);
                    queue.Enqueue(option);
                    queue.Enqueue(factor.ToString());
                    num /= factor;
                }
                else
                {
                    int num2 = random2.Next(maxNum) + 1;
                    queue.Enqueue(option);
                    queue.Enqueue(num2.ToString());
                    num *= num2;
                }
            }
            return queue;
        }

        /// <summary>
        /// 给定一个加减法表达式所含操作数的个数，生成一个随机的加减法表达式，并以队列的形式返回
        /// </summary>
        /// <param name="count"> 符号数个数 </param>
        /// <returns> 加减法表达式队列 </returns>
        public static Queue<string> additionAndSubtractionFormulaGenerator(int count)
        {
            Queue<string> queue = new Queue<string>();
            int num = random.Next(maxNum) + 1;
            queue.Enqueue(num.ToString());
            while (--count > 0)
            {
                string option = op[random.Next(2)];
                queue.Enqueue(option);
                queue.Enqueue((random.Next(maxNum) + 1).ToString());
            }
            return queue;
        }

        /// <summary>
        /// 从一个数的所有因式中随机选择一个返回
        /// </summary>
        /// <param name="num"> 数 </param>
        /// <returns> num 的一个因式 </returns>
        private static int chooseRandomFactor(int num)
        {
            int[] arr = new int[num + 1];
            int size = 0;
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    arr[size++] = i;
                    arr[size++] = num / i;
                }
            }
            int r = random2.Next(size);
            return arr[r];
        }

        /// <summary>
        /// 将两个队列合并
        /// </summary>
        /// <param name="queue">  主队列 </param>
        /// <param name="queue2"> 被合并队列 </param>
        private static void mergeQueue(Queue<string> queue, Queue<string> queue2)
        {
            while (queue2.Count > 0)
            {
                queue.Enqueue(queue2.Dequeue());
            }
        }

    }
}
