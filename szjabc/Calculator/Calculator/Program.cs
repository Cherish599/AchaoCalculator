using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace progress2
{
    public class Problem
    {
        public int a, b, c, d, n, sum;
        char[] s = { '+', '-', '*', '/' };
       public Problem(int n)
        {
            //this.n = n;
        }
        public int Print()
        {
            Random random = new Random();
            Console.WriteLine("请输入题目个数：");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                // char s1 = s[t];
                int t = random.Next(1, 9);
                //char s2 = s[t];
                a = random.Next(1, 100);   //生成1-100之间的随机数
                b = random.Next(1, 100);
                c = random.Next(1, 100);
                d = random.Next(1, 100);
                if (t == 1)
                {
                    sum = a + b + c;
                    Console.WriteLine(a + "+" + b + "+" + c + "=" + sum);
                }
                else if (t == 2)
                {
                    c = random.Next(1, a + b);
                    for (; a + b - c < 0;)
                        c = random.Next(1, a + b);
                    sum = a + b - c;
                    Console.WriteLine(a + "+" + b + "-" + c + "=" + sum);
                }
                else if (t == 3)
                {
                    sum = a + b * c;
                    Console.WriteLine(a + "+" + b + "*" + c + "=" + sum);
                }
                else if (t == 4)
                {

                    for (; b % c != 0; c = random.Next(1, b))
                        c = random.Next(2, b);
                    sum = a + b / c;
                    Console.WriteLine(a + "+" + b + "/" + c + "=" + sum);
                }
                else if (t == 5)
                {

                    for (; b % c != 0;)
                        c = random.Next(2, b);
                    sum = a * d + b / c;
                    Console.WriteLine(a + "*" + d + "+" + b + "/" + c + "=" + sum);
                }
                else if (t == 6)
                {

                    for (; b % c != 0; c = random.Next(1, b))

                        d = random.Next(2, a);
                    sum = a + b / c - d;
                    Console.WriteLine(a + "+" + b + "/" + c + "-" + d + "=" + sum);

                }
                else if (t == 7)
                {

                    for (; b % c != 0;)
                        c = random.Next(1, b);
                    sum = a + b / c * d;
                    Console.WriteLine(a + "+" + b + "/" + c + "*" + d + "=" + sum);
                }
                else if (t == 8)
                {


                    sum = a * b + c * d;
                    Console.WriteLine(a + "*" + b + "+" + c + "*" + d + "=" + sum);
                }
                else if (t == 9)
                {

                    for (; c % d != 0;)
                        d = random.Next(1, c);
                    sum = a * b + c / d;
                    Console.WriteLine(a + "*" + b + "+" + c + "/" + d + "=" + sum);
                }
            }
            return sum;

        }
        public void Writew()
        {
            string fileName = @"F:\\Temp.txt";
            StreamWriter sa = new StreamWriter(fileName);
            sa.WriteLine();
            sa.Flush();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Problem v = new Problem(1);
            v.Print();
            Console.Read();
        }
    }
}