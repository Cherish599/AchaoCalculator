using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _Random
{
    class Program
    {
        static void Main(string[] args)
        {
            mathvoid op = new mathvoid();
            int a = 0;
            int n = 0;
            int i = 0;
            string Z = "";
            Random r = new Random();
            a = r.Next(0, 4);

            Console.WriteLine("");
            Console.WriteLine("请输入出题数目：");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Z = a.ToString();
                switch (Z)
                {
                    case "1":
                        op.mathjia();
                        continue;
                    case "2":
                        op.mathjian();
                        continue;
                    case "3":
                        op.mathcheng();
                        continue;
                    case "4":
                        op.mathchu();
                        continue;                   
               }              
            }
            Console.WriteLine("总共答对" + op.getright() + "道题！答错"+op.getwrongt ()+"道题！");
        }
    }
}