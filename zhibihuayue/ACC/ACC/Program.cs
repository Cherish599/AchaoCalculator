using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ACC
{

    public class Program
    {

        public static void Main(string[] args)
        {
            string Run;
            Console.Write("阿超的四则运算题目生成器\n生成练习题数量：");
            int n = 100000;
            Writetitle(n);
            for (int i = 0; i < n; i++)
            {
                string Star = Define();
                Run = Count(Star);
                Console.WriteLine("\n第{0,1}题", (i + 1));
                Console.WriteLine(Run);
                System.Threading.Thread.Sleep(100);
                Write(Run, i);
            }
            Console.Write("\n\n阿超的四则运算练习题生成完毕，共{0,1}道\n生成题目文件：D:\\于丁软件工程实践\\第二次作业\\阿超的四则运算\\AchaoCalculator\\subject.txt", n);
            Console.Read();
        }


        private static string Define()
        {
            Random Problem = new Random();
            string Start = "";
            int Sign;
            int Do = 0;
            int Number = Problem.Next(2, 4);
            for (int i = 0; i < (2 * Number) + 1; i++)
            {
                if (i % 2 == 0)
                {
                    Sign = Problem.Next(0, 101);
                    Start += Sign;
                }
                else
                {
                    Do = Problem.Next(0, 4);
                    Start += Makesign(Do);
                }
            }
            return Start;
        }


        public static string Makesign(int number)
        {
            string sign = "";
            switch (number)
            {
                case 0:
                    sign = "+";
                    break;
                case 1:
                    sign = "-";
                    break;
                case 2:
                    sign = "*";
                    break;
                case 3:
                    sign = "/";
                    break;
            }
            return sign;
        }


        public static string Count(string String)
        {

            DataTable dt = new DataTable();
            object obj = dt.Compute(String, "");
            while (obj.ToString().Contains("-") || obj.ToString().Contains(".") || String.Contains("/0"))
            {
                String = Define();
                obj = dt.Compute(String, "");
            }
            String = String + "=" + obj.ToString();
            return String;

        }


        public static void Writetitle(int n)
        {
            StreamWriter sw = File.AppendText(@"D:\于丁软件工程实践\第二次作业\阿超的四则运算\AchaoCalculator\subject.txt");
            sw.WriteLine("阿超的四则运算练习题\n(共{0,1}道题)", n);
            sw.Flush();
            sw.Close();
        }


        public static void Write(string result, int i)
        {
            StreamWriter sw = File.AppendText(@"D:\于丁软件工程实践\第二次作业\阿超的四则运算\AchaoCalculator\subject.txt");
            sw.WriteLine("\n第{0,1}题", (i + 1));
            sw.WriteLine(result);
            sw.Flush();
            sw.Close();
        }

    }
}
