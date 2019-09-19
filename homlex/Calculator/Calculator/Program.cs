using System;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = 0;
            try
            {
                lines = int.Parse(args[0]);
                //lines = 100;
                if (lines <=0)
                {
                    Console.WriteLine("\n 仅支持 `$ Calculator <一个正整数>` 的形式！"); return;
                }
                string path = Directory.GetCurrentDirectory() + "\\subject.txt";
                WriteFile.save(path, new Formular(1, 8).GetFullExpressions(lines));
                System.Console.WriteLine("\n 已保存至 " + Directory.GetCurrentDirectory() + "\\subject.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("\n 仅支持 `$ Calculator <一个正整数>` 的形式！"); return;
            }
            return;
        }
    }
}
