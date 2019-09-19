using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.IO;
using System.Diagnostics;
namespace test
{
    public class GetCal
    {
        public string GetCalculation(Random random)
        {
            string str = "";
            string[] list1 = new string[4];
            list1[0] = "+";
            list1[1] = "-";
            list1[2] = "*";
            list1[3] = "/";
            int f = 0, tip;
            ArrayList list = new ArrayList();
            int num = random.Next(2, 4);
            for (int j = 0; j <= num; j++)
            {
                while (f < j)
                {
                    int num1 = random.Next(0, 4);
                    list.Add(list1[num1]);
                    f++;
                }
                tip = random.Next(0, 100);
                list.Add(tip);
            }
            f = 0;
            foreach (var str1 in list)
            {
                str += str1;
            }

            return str;
        }
        public int  GetResult(int n)
        {
            Random Number = new Random();
            DataTable dt = new DataTable();
            string re;
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str = GetCalculation(Number);
                string result = dt.Compute(str, "false").ToString();
                while(result.Contains(".")||result.Contains("-"))
                {
                    str = GetCalculation(Number);
                    result = dt.Compute(str, "false").ToString();
                }
                str = str + "=";
                re = str + result;
                writetxt(re);
                Console.WriteLine(str+"{0}",result);

            }
            return 0;
        }
        //写入文档
        public int writetxt(string str)
        {
            string path = @"E:\作业\系统设计与分析\AchaoCalculator\yatangtang\Calculator\result.txt";
            if (File.Exists(path))
            {
            }
            else
            {
                File.Create(path).Dispose();
            }
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            return 0;
        }
    }
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你需要的四则运算表达式的个数");
            int count = int.Parse(Console.ReadLine());
            GetCal cal = new GetCal();
            cal.GetResult(count);
            Console.ReadLine();
        }
    }
}
