using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int time;
            string s, s2;
            Console.WriteLine("请输入所生成题目数量：");
            time = int.Parse(Console.ReadLine());

            for (int i = 1; i <= time;)
            {
                Random Number = new Random(Guid.NewGuid().GetHashCode());
                int a= Number.Next(0, 100);
                int b = Number.Next(0, 100);
                int d = Number.Next(0, 100);
                int c = Number.Next(0,17);
                int n1 = 0;
                int n2 = 0;
                switch (c)
                {
                   case 0:
                        s = "+";
                        n2 = Calculate(a, b, s);
                        if (n2 > 0)
                        {
                            n1 = Calculate(n2, d, s);
                            if (n1 > 0)
                            {
                                Console.WriteLine(a + "+" + b + "+" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 1:
                        s = "-";
                        n2 = Calculate(a, b, s);
                        if (n2 % 2 == 0 && n2 > 0)
                        {
                            n1 = Calculate(n2, d, s);
                            if (n1 % 2 == 0 && n1 > 0)
                            {
                                Console.WriteLine(a + "-" + b + "-" + d + "=" + n1);
                                i++;

                            }

                        }

                        break;
                   case 2:
                        s = "*";
                        n2 = Calculate(a, b, s);
                        if (n2 % 2 == 0 && n2 > 0)
                        {
                            n1 = Calculate(n2, d, s);
                            if (n1 % 2 == 0 &&n1 > 0)
                            {
                                Console.WriteLine(a + "*" + b + "*" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 3:
                        if (a % b == 0)
                        {
                            s = "/";
                        n2 = Calculate(a, b, s);
                            if (n2 % 2 == 0 && n2 > 0)
                            {
                                if (n2 % d == 0)
                                {
                                    n1 = Calculate(n2, d, s);
                                    if (n1 % 2 == 0 && n1 > 0)
                                    {
                                        Console.WriteLine(a + "/" + b + "/" + d + "=" + n1);
                                        i++;

                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        s = "+";
                        s2 = "-";
                        n2 = Calculate(a, b, s);
                        if (n2 > 0)
                        {
                            n1 = Calculate(n2, d, s2);
                            if (n1 > 0)
                            {
                                Console.WriteLine(a + "+" + b + "-" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 5:
                        s = "+";
                        s2 = "*";
                        n2 = Calculate(b, d, s2);
                        if (n2 > 0)
                        {
                            n1 = Calculate(a, n2, s);
                            if (n1 % 2 == 0 && n1 > 0)
                            {
                                Console.WriteLine(a + "+" + b + "*" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 6:
                        if (b % d == 0)
                        { 
                            s = "+";
                        s2 = "/";
                        n2 = Calculate(b, d, s2);
                            if (n2 > 0)
                            {
                                n1 = Calculate(a, n2, s);
                                if (n1 % 2 == 0 && n1 > 0)
                                {
                                    Console.WriteLine(a + "+" + b + "/" + d + "=" + n1);
                                    i++;

                                }
                            }
                        }
                        break;
                    case 7:
                        s = "-";
                        s2 = "+";
                        n2 = Calculate(a, b, s);
                        if (n2 > 0)
                        {
                            n1 = Calculate(n2, d, s2);
                            if (n1 > 0)
                            {
                                Console.WriteLine(a + "-" + b + "+" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 8:
                        s = "-";
                        s2 = "*";
                        n2 = Calculate(b, d, s2);
                        if (n2 > 0)
                        {
                            n1 = Calculate(a, n2, s);
                            if (n1 % 2 == 0 && n1 > 0)
                            {
                                Console.WriteLine(a + "+" + b + "*" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 9:
                        if (b % d == 0)
                        { 
                            s = "-";
                        s2 = "/";
                        n2 = Calculate(b, d, s2);
                            if (n2 > 0)
                            {
                                n1 = Calculate(a, n2, s);
                                if (n1 % 2 == 0 && n1 > 0)
                                {
                                    Console.WriteLine(a + "-" + b + "/" + d + "=" + n1);
                                    i++;

                                }
                            }
                        }
                        break;
                    case 10:
                        s = "*";
                        s2 = "+";
                        n2 = Calculate(a, b, s);
                        if (n2 % 2 == 0 && n2 > 0)
                        {
                            n1 = Calculate(n2, d, s2);
                            if (n1 > 0)
                            {
                                Console.WriteLine(a + "*" + b + "+" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 11:
                        s = "*";
                        s2 = "-";
                        n2 = Calculate(a, b, s);
                        if (n2 % 2 == 0 && n2 > 0)
                        {
                            n1 = Calculate(n2, d, s2);
                            if (n1 > 0)
                            {
                                Console.WriteLine(a + "*" + b + "-" + d + "=" + n1);
                                i++;

                            }

                        }
                        break;
                    case 12:
                        s = "*";
                        s2 = "/";
                        n2 = Calculate(a, b, s);
                        if (n2 % 2 == 0 && n2 > 0)
                        {
                            if (n2 % d == 0)
                            {
                                n1 = Calculate(n2, d, s2);
                                if (n1 % 2 == 0 && n1 > 0)
                                {
                                    Console.WriteLine(a + "*" + b + "/" + d + "=" + n1);
                                    i++;

                                }
                            }
                        }
                        break;
                    case 13:
                        if (a % b == 0)
                        { 
                            s = "/";
                        s2 = "+";
                        n2 = Calculate(a, b, s);
                            if (n2 % 2 == 0 && n1 > 0)
                            {
                                n1 = Calculate(n2, d, s2);
                                if (n1 > 0)
                                {
                                    Console.WriteLine(a + "/" + b + "+" + d + "=" + n1);
                                    i++;

                                }
                            }
                        }
                        break;
                    case 14:
                        if (a % b == 0)
                        { 
                            s = "/";
                        s2 = "-";
                        n2 = Calculate(a, b, s);
                            if (n2 % 2 == 0 && n2 > 0)
                            {
                                n1 = Calculate(n2, d, s2);
                                if (n1 > 0)
                                {
                                    Console.WriteLine(a + "/" + b + "-" + d + "=" + n1);
                                    i++;

                                }
                            }
                        }
                        break;
                    case 15:
                        if (a % b == 0)
                        {
                            s = "/";
                            s2 = "*";
                            n2 = Calculate(a, b, s);
                            if (n2 % 2 == 0 && n2 > 0)
                            {
                                n1 = Calculate(n2, d, s2);
                                if (n1 % 2 == 0 && n1 > 0)
                                {
                                    Console.WriteLine(a + "/" + b + "*" + d + "=" + n1);
                                    i++;

                                }

                            }
                        }
                        break;
                }


            }
            Console.ReadKey();
        }

        public static int Calculate(int  a1, int a2, string sign)
        {
            int  sum = 0;
            switch (sign)
            {
                case "-":
                    sum = a1 - a2;
                    break;
                case "+":
                    sum = a1 + a2;
                    break;
                case "*":
                    sum = a1 * a2;
                    break;
                case "/":
                    sum = a1 / a2;
                    break;
            }
            return sum;
        }
    }
}