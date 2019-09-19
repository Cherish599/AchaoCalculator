using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 杨也1
{
    class Program
    {
        static void Main(string[] args)
        {
            mathvoid op = new mathvoid();
            string Z = "";
            do
            {
                Console.WriteLine("-------------------------------四则运算-------------------------");
                Console.WriteLine("");
                Console.WriteLine("请选择您使用的运算方法:1.加法 2.减法 3.乘法 4.除法 5.退出！");
                Z = Console.ReadLine();
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
                    case "5":
                        op.result();
                        break;
                    default:
                        Console.WriteLine("输入无效！");
                        continue;
                }
                break;
            }
            while (true);
        }
    }
}
