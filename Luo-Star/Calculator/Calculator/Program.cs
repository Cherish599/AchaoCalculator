using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Symbol
    {
        public static string k, o, l, num, num1, num2, num3, str;
        public string GetSymbol()
        {
            Random random = new Random();
            char[] a = new char[] { '+', '-', '*', '/' };
            Thread.Sleep(15);
            int inter1 = random.Next(0, 4);
            return a[inter1].ToString();
        }
        public string Getnum()
        {
            int number1;
            Random random = new Random();
            Thread.Sleep(15);
            number1 = random.Next(1, 100);
            return number1.ToString();
        }

        public object TwoSymbolCal()
        {

            Symbol a = new Symbol();
            l = a.GetSymbol();
            k = a.GetSymbol();
            num = a.Getnum();
            num1 = a.Getnum();
            num2 = a.Getnum();
            str = num + l + num1 + k + num2;
            DataTable dt = new DataTable();
            object obj = dt.Compute(str, null);
            str += "=" + obj;
            return obj;
        }

        public object ThreeSymbolCal()
        {

            Symbol a = new Symbol();
            l = a.GetSymbol();
            k = a.GetSymbol();
            o = a.GetSymbol();
            num = a.Getnum();
            num1 = a.Getnum();
            num2 = a.Getnum();
            num3 = a.Getnum();
            str = num + l + num1 + k + num2 + o + num3;
            DataTable dt = new DataTable();
            object obj = dt.Compute(str, null);
            str += "=" + obj;
            return obj;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            int i = 0, choose;
            bool point, minus;
            Console.WriteLine("请输入需要出的题目数n\n");
            int n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                string r, r1;
                Symbol a = new Symbol();
                Random random = new Random();
                choose = random.Next() % 2;
                if (choose == 1)
                {
                    r = a.TwoSymbolCal().ToString();
                }
                else
                {
                    r = a.ThreeSymbolCal().ToString();
                }

                minus = r.Contains("-");
                point = r.Contains(".");

                if (point == true || minus == true)
                {
                    i--;
                }
                else
                {
                    Console.WriteLine(Symbol.str);
                    r1 = Symbol.str.Replace('/', '÷');
                    Symbol.str = r1.Replace('*', '×');
                    StreamWriter sw = new StreamWriter("d:/example.txt", true);
                    sw.WriteLine(Symbol.str);
                    sw.Close();
                }
                i++;
            }
        }
    }
}
