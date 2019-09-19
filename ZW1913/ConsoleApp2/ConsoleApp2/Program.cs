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
            string Z = "";
            do
            {
                int z = new Random().Next(4) + 1;
                switch (z)
                {
                    case 1:
                        op.mathjia();
                        continue;
                    case 2:
                        op.mathjian();
                        continue;
                    case 3:
                        op.mathcheng();
                        continue;
                    case 4:
                        op.mathchu();
                        continue;
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
