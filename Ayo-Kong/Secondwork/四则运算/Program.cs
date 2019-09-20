using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inputs ca = new Inputs();
            string s = null;
            Console.WriteLine("----------------------------------------四则运算题目-----------------------------------------");
            Console.WriteLine("请输入题目个数：");
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                s = s + Inputs.R(Inputs.Operation()) + "\n";
                System.Threading.Thread.Sleep(100);
            }
            Console.WriteLine(s);
            Console.ReadKey();
            StreamWriter sw = new StreamWriter("D:\\软工作业\\AchaoCalculator\\Ayo-Kong\\result.txt");
            sw.Write(s);
            sw.Close();

        }
    }
}

