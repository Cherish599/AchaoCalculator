using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
     public static class Program
    {
        private static string[] op = new string[] { "+", "-", "*", "/" };
        private static Random random = new Random();
        private static int maxNum = 10;

        //判断符号优先级
        internal static int precedence(string q)
        {
            switch (q)
            {
                case "+":
                case "-": return 1;
                case "*":
                case "/":
                    return 2;
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                string question = MakeFormula();
                Console.WriteLine(question);
                int ret = Solve(question);
                Console.WriteLine(ret);
            }
            Console.ReadLine();
        }
        // 制造公式
        public static string MakeFormula()
        {
            StringBuilder build = new StringBuilder();
            int c = (int)(GlobalRandom.NextDouble * 2) + 1; // 生成随机计数
            int s = 0;
            int numbera = (int)(GlobalRandom.NextDouble * 99) + 1; //5
            build.Append(numbera);
            while (s <= c)
            {
                int operation = (int)(GlobalRandom.NextDouble * 4); // 生成运算符
                if (op[operation] == "/") 
                {
                    build.Append("*"); //5*
                    Queue<String> queue = multipleFormulaGenerator(3);//5*2/2
                    while (queue.Count != 0)
                    {
                        build.Append(queue.Dequeue()); //5*  5*2/2
                    }
                }
                else
                {
                    int numbeb = (int)(GlobalRandom.NextDouble * 99) + 1;
                    build.Append(op[operation]).Append(numbeb);
                }
                s++;

            }
            //Console.WriteLine(build.ToString());
            return build.ToString();
        }

        // 生成随机数
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
        //将中缀表达式，转化成后缀表达式，并计算后缀表达式的值
        public static int Solve(string formula)
        {
            Queue<string> queue = new Queue<string>();
            int i = 0; string num = "";
            while (i < formula.Length)
            {
                if (formula[i] != '*' && formula[i] != '/' && formula[i] != '+' && formula[i] != '-')
                {
                    num += formula[i];
                }
                else
                {
                    queue.Enqueue(num);
                    queue.Enqueue("" + formula[i]);
                    num = "";
                }
                i++;
            }
            queue.Enqueue(num);

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
            Stack<string> stack1 = new Stack<string>(); 
            foreach (string symbol in queue2)
            {
                if (!symbol.Equals("+") && !symbol.Equals("-") && !symbol.Equals("/") && !symbol.Equals("*"))
                {
                    stack1.Push(symbol);
                }
                else
                {
                    int w = int.Parse(stack1.Pop()), e = int.Parse(stack1.Pop());
                    switch (symbol)
                    {
                        case "+":
                            stack1.Push((w + e).ToString());
                            break;
                        case "-":
                            stack1.Push((e - w).ToString());
                            break;
                        case "*":
                            stack1.Push((w * e).ToString());
                            break;
                        default:
                            stack1.Push((e / w).ToString());
                            break;
                    }
                }
            }
            return int.Parse(stack1.Pop());
        }

       
        /// 给定一个乘除法表达式所含操作数的个数，生成一个随机的乘除法表达式，并以队列的形式返回
        public static Queue<string> multipleFormulaGenerator(int count)
        {
            Queue<string> queue = new Queue<string>();
            int number = random.Next(maxNum) + 1;
            queue.Enqueue(number.ToString());
            while (--count > 0)
            {
                string option = op[2 + random.Next(2)];
                if (string.ReferenceEquals(option, "/"))
                {
                    int factor = chooseRandomFactor(number);
                    queue.Enqueue(option);
                    queue.Enqueue(factor.ToString());
                    number /= factor;
                }
                else
                {
                    int numberc = random.Next(maxNum) + 1;
                    queue.Enqueue(option);
                    queue.Enqueue(numberc.ToString());
                    number *= numberc;
                }
            }
            return queue;
        }

     
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
            int r = random.Next(size);
            return arr[r];
        }
    }
}
