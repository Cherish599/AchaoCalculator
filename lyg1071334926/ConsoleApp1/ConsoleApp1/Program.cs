using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] oper = { "+", "-", "*", "/" };
            int n;
            Console.WriteLine("出几道题");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("已经生成题库");
            string question = "";
            //随机类对象
            _random random = new _random();
            //四则运算对象
            Compute compute;
            //运算结果
            float res;
            //文件url
            string fileName1 = @"E:\新建文件夹 (3)\AchaoCalculator\lyg1071334926\homeworks.txt";
            string fileName2 = @"E:\新建文件夹 (3)\AchaoCalculator\lyg1071334926\results.txt";
            StreamWriter sw1 = new StreamWriter(fileName1);
            StreamWriter sw2 = new StreamWriter(fileName2);
            for (int i = 0; i < n; i++)
            {
                question = "";
                float num;
                int _operator;
                for (int j = 0; j < random.return_num(); j++)
                {
                    //储存操作数和操作符代号
                    num = random.return_operand();
                    _operator = random.return_operator();
                    question += num;
                    switch (_operator)
                    {
                        case 0:
                            question += oper[0];
                            break;
                        case 1:
                            question += oper[1];
                            break;
                        case 2:
                            question += oper[2];
                            break;
                        case 3:
                            question += oper[3];
                            break;
                    }
                }
                num = random.return_operand();
                question += num;
                compute = new Compute(question);
                res = compute.run();
                //若结果不为整数，此次操作无效
                if (Math.Abs(res - (int)res) != 0)
                {
                    i--;
                    continue;
                }
                question += "=";
                sw1.WriteLine(question);
                question += res;
                sw2.WriteLine(question);
            }
            sw1.Flush();
            sw2.Flush();
            sw1.Close();
            sw2.Flush();
            Console.WriteLine(@"文件在 url(E:\新建文件夹 (3)\AchaoCalculator\lyg1071334926\lyg1071334926) ");
            Console.ReadKey();
        }
    }
    //产生随机数
    public class _random
    {
        //随机数对象
        Random random = new Random();
        //构造函数
        public _random()
        {

        }
        //操作数（0-100）
        public float return_operand()
        {
            return (float)random.Next(0, 101);
        }
        //有几个运算符（2-3）
        public int return_num()
        {
            return random.Next(2, 4);
        }
        //运算符数组对应的下标
        public int return_operator()
        {
            return random.Next(0, 4);
        }
    }
    //四则运算类，栈的运用
    public class Compute
    {
        public static char[] str = new char[100];
        private static char[] temp;
        //操作数栈
        Stack<float> num = new Stack<float>();
        //符号栈
        Stack<char> ch = new Stack<char>();
        public Compute(string question)
        {
            //初始化
            //num.Clear();
            //ch.Clear();
            temp = question.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (i < temp.Length)
                {
                    str[i] = temp[i];
                }
                else
                {
                    str[i] = '\0';
                }
            }
        }
        //权重判断
        public int Priority(char s)
        {
            switch (s)
            {
                case '*':
                    return 2;
                case '/':
                    return 2;
                case '+':
                    return 1;
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }
        /// <summary>
        /// 测试数据： 71-97+23=-49？
        public float run()
        {
            int i = 0;
            float tmp = 0, j;
            while (str[i] != '\0' || ch.Count != 0)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    tmp = tmp * 10 + str[i] - '0';
                    i++;
                    if (str[i] < '0' || str[i] > '9')
                    {
                        num.Push(tmp);
                        tmp = 0;
                    }
                }
                else
                {
                    if (ch.Count != 0 && Priority(str[i]) <= Priority(ch.Peek()))
                    {
                        switch (ch.Pop())
                        {
                            case '+':
                                num.Push(num.Pop() + num.Pop());
                                break;
                            case '-':
                                j = num.Pop();
                                num.Push(num.Pop() - j);
                                break;
                            case '*':
                                num.Push(num.Pop() * num.Pop());
                                break;
                            case '/':
                                j = num.Pop();
                                num.Push(num.Pop() / j);
                                break;
                        }
                        continue;
                    }


                    if (str[i] != '\0' && ((num.Count != 0) || (Priority(str[i]) > Priority(ch.Peek()))))
                    {
                        ch.Push(str[i]);
                        i++;
                        continue;
                    }


                }
            }
            return num.Pop();

        }
    }
}

