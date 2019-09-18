using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 个人第二次作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要就是数目:");
            int n = int.Parse(Console.ReadLine());
            char[] FH = new char[] { '+', '-', '*', '/' };
            string s = "";
            int x = 10;
            Random Max = new Random(10);
            long tick = DateTime.Now.Ticks;
            Random Ch = new Random();
            for (int i = 0; i < n; i++)
            {
                int num1 = Max.Next(0, 100);
                int num2 = Max.Next(0, 100);
                int fh = Ch.Next(0, 4);
                double result;
                if (FH[fh] == '+')
                    result = num1 + num2;
                else if (FH[fh] == '-')
                    result = num1 - num2;
                else if (FH[fh] == '*')
                    result = num1 * num2;
                else
                {
                    result = (double)num1 / (double)num2;
                }
                Console.WriteLine(num1.ToString() + FH[fh].ToString() + num2.ToString() + "=" + result.ToString());
            }
        }
    }
}
