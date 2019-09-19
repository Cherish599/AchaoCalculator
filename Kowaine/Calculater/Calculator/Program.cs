using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please input the number of problems: ");
            //int n = int.Parse(Console.ReadLine());
            int n = 1000000;
            string[] problems = new string[n];
            for (int i = 0; i < n; ++i)
            {
                //生成一组数据
                ArrayList data = generateData();
                int result = Calculate((Stack)(((Stack)data[0]).Clone()), (Stack)(((Stack)data[1]).Clone()));
                if (result < 0)
                {
                    i--;
                    continue;
                }
                problems[i] = toString((Stack)(((Stack)data[0]).Clone()), (Stack)(((Stack)data[1]).Clone()), result);
            }
            writeToFile(problems);

        }


        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="ops">操作符的反向栈</param>
        /// <param name="nums">操作数的反向栈</param>
        /// <returns>最终结果</returns>
        public static int Calculate(Stack ops, Stack nums)
        {
            // 生成两个栈供使用
            Stack opStack = new Stack();
            Stack numStack = new Stack();

            // 开始入栈计算
            numStack.Push(nums.Pop());
            while (nums.Count != 0)
            {
                numStack.Push(nums.Pop());
                Operator thisOp = (Operator)ops.Pop();
                if (ops.Count != 0)
                {
                    Operator nextOp = (Operator)ops.Peek();
                    // 比较优先级，若当前运算符优先级大于等于下一个运算符，则先运算
                    if (thisOp.getPriority() >= nextOp.getPriority())
                    {
                        int x2 = (int)numStack.Pop();
                        int x1 = (int)numStack.Pop();
                        int result = thisOp.doCal(x1, x2);
                        numStack.Push(result);
                    }
                    else
                    {
                        opStack.Push(thisOp);
                    }
                }
                else
                {
                    opStack.Push(thisOp);
                }
            }
            // 确保运算完全完成
            Stack restOps = new Stack(opStack);
            Stack restNums = new Stack(numStack);
            while (restOps.Count != 0)
            {
                int x1 = (int)restNums.Pop();
                int x2 = (int)restNums.Pop();
                restNums.Push(((Operator)restOps.Pop()).doCal(x1, x2));
            }

            return (int)restNums.Pop();
        }

        /// <summary>
        /// 生成一组计算所需数据
        /// </summary>
        /// <returns>ArrayList(操作符反向栈， 操作数反向栈)</returns>
        public static ArrayList generateData()
        {
            // 创建工厂
            OperatorFactory operatorFactory = new OperatorFactory();
            NumberFactory numberFactory = new NumberFactory();

            // 操作符数量
            Random random = new Random();
            // 生成操作符
            int opCount = random.Next(2, 4);
            ArrayList opList = new ArrayList();
            for (int i = 0; i < opCount; ++i)
            {
                opList.Add(operatorFactory.randOprator());
            }
            opList.Reverse();

            // 根据操作符数量生成操作数
            ArrayList numList = new ArrayList();
            numList.Add(numberFactory.randNumber(1, 99));
            int divCount = 0;
            for (int i = 0; i < opCount; ++i)
            {
                string nextOp;
                if (i == opCount - 1)
                {
                    nextOp = "";
                }
                else
                {
                    nextOp = ((Operator)opList[i + 1]).toString();
                }
                if (((Operator)opList[i]).toString() == "/" && nextOp != "/")
                {
                    // 在连续除号的最后一个生成数字
                    int[] numArray = new int[divCount + 1];
                    numArray[divCount] = 101;
                    while (numArray[divCount] > 99)
                    {
                        numList[i - divCount] = numberFactory.randNumber(1, 10);
                        int lastNum = (int)numList[i - divCount];
                        int fistNum = lastNum;
                        //(100 / lastNum) >= 3 ? (100 / lastNum) : 3
                        int n = numberFactory.randNumber(2, (99 / lastNum) >= 3 ? (99 / lastNum) : 3);
                        numArray[0] = n * lastNum;
                        for (int j = 1; j < divCount + 1; ++j)
                        {
                            lastNum = numArray[j - 1];
                            n = numberFactory.randNumber(2, (99 / lastNum) >= 3 ? (99 / lastNum) : 3);
                            numArray[j] = n * lastNum * fistNum;
                        }
                    }
                    for (int j = 0; j < divCount + 1; ++j)
                    {
                        numList.Add(numArray[j]);
                    }
                    divCount = 0;
                }
                else if (((Operator)opList[i]).toString() == "/" && nextOp == "/")
                {
                    divCount++;
                }
                else
                {
                    numList.Add(numberFactory.randNumber(0, 99));
                }
            }

            // 转化为栈
            Stack opStack = new Stack();
            for (int i = 0; i < opList.Count; ++i)
            {
                opStack.Push(opList[i]);
            }
            Stack numStack = new Stack();
            for (int i = 0; i < numList.Count; ++i)
            {
                numStack.Push(numList[i]);
            }

            // 转化为一个List
            ArrayList data = new ArrayList();
            data.Add(opStack);
            data.Add(numStack);

            return data;
        }

        public static string toString(Stack opStack, Stack numStack, int result)
        {
            string resultString = "";
            resultString += ((int)numStack.Pop()).ToString();
            int count = opStack.Count;
            for (int i = 0; i < count; i++)
            {
                resultString += ((Operator)opStack.Pop()).toString();
                resultString += ((int)numStack.Pop()).ToString();
            }
            resultString += "=" + result.ToString();
            return resultString;
        }

        public static void writeToFile(string[] problems)
        {
            string path = "subject.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter writer = new StreamWriter(path, true);
            for (int i = 0; i < problems.Length; ++i)
            {
                // 测试输出
                //Console.WriteLine(problems[i] + "\n");

                writer.WriteLine(problems[i]);

            }
            writer.Close();
            writer.Dispose();
        }
    }

    /// <summary>
    /// 操作符基类
    /// </summary>
    public interface Operator
    {
        //计算
        int doCal(int x, int y);

        string toString();

        int getPriority();
    }

    public class Add : Operator
    {
        private int priority;

        public Add()
        {
            priority = 0;
        }


        public int doCal(int x, int y)
        {
            return x + y;
        }

        public string toString()
        {
            return "+";
        }

        public int getPriority()
        {
            return priority;
        }

    }

    public class Sub : Operator
    {
        private int priority;

        public Sub()
        {
            priority = 1;
        }


        public int doCal(int x, int y)
        {
            return x - y;
        }

        public string toString()
        {
            return "-";
        }

        public int getPriority()
        {
            return priority;
        }
    }

    public class Mul : Operator
    {
        private int priority;

        public Mul()
        {
            priority = 2;
        }


        public int doCal(int x, int y)
        {
            return x * y;
        }

        public string toString()
        {
            return "*";
        }

        public int getPriority()
        {
            return priority;
        }
    }

    public class Div : Operator
    {
        private int priority;

        public Div()
        {
            priority = 3;
        }


        public int doCal(int x, int y)
        {
            return x / y;
        }

        public string toString()
        {
            return "/";
        }

        public int getPriority()
        {
            return priority;
        }
    }

    /// <summary>
    /// 生成运算符的工厂类
    /// </summary>
    public class OperatorFactory
    {
        private static Random random = new Random();

        /// <summary>
        /// 生成一个随机的操作符类
        /// </summary>
        /// <returns>生成的操作符类</returns>
        public Operator randOprator()
        {
            int index = random.Next(0, 4);
            switch (index)
            {
                case 0:
                    return new Add();
                case 1:
                    return new Sub();
                case 2:
                    return new Mul();
                case 3:
                    return new Div();
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// 产生随机数的工厂类
    /// </summary>
    public class NumberFactory
    {
        private static Random random = new Random();


        public int randNumber(int minNum, int maxNum)
        {
            return random.Next(minNum, maxNum + 1);
        }
    }
}
