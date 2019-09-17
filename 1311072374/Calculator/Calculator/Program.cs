using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        public static string Suijiyunsuan()//产生随机运算式
        {
            Random random = new Random();
            string result = null;

            int number = random.Next(0, 101);//产生随机数
            int opnumber = random.Next(2, 4);//产生随机运算符个数
            char[] Operator = { '+', '-', '*', '/' };
            result += number;

            for (int i = 1; i <= opnumber; i++)
            {
                Thread.Sleep(300);
                number = random.Next(0, 101);//产生随机数
                int op = random.Next(0, 4);//产生随机运算符
                result = result + Operator[op] + number;
            }
            return result;
        }
        public static string Panduan(string fml)//判断结果是否有小数或负数
        {
            DataTable data = new DataTable();//生成data表
            object a = null;
            a = data.Compute(fml, "");

            while (a.ToString().Contains(".") || a.ToString().Contains("/0"))
            {
                fml = Suijiyunsuan();
                a = data.Compute(fml, "");
            }

            return fml + "=" + a.ToString();
        }
        public static int Write(string fml)//将结果写到记事本中
        {

            try
            {
                string fileName = @"C:\Users\asus\Desktop\git\AchaoCalculator\1311072374\四则运算.txt";
                StreamWriter sw = new StreamWriter(fileName,true);
                sw.WriteLine(fml);
                sw.Flush();
                sw.Close();
                Console.WriteLine("随机成功！！！");
                return 1;
            }
            catch
            {
                Console.WriteLine("随机失败！！！");
                return 0;
            }

        }
        static void Main(string[] args)
    {
        int n = 0;

        Console.WriteLine("请输入练习题个数：");
        n = int.Parse(Console.ReadLine());
            for ( int i = 1; i <= n; i++)
            {
                Program.Write(Panduan(Suijiyunsuan()));//调用函数

            }
        }
    }
}