using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        public static char[] Operator = { '+', '-', '*', '/' };   //生成运算符

        public static void Main(string[] args)
        {
            int countNumber = 0;
            string Result = null;

            Console.Write("请输入n：");
            countNumber = int.Parse(Console.ReadLine());     //读取生成个数


            for (int i = 0; i < countNumber; i++)
            {
                Result += Inspection(Generator()) + "\r\n";               //生成四则运算
                Thread.Sleep(100);
            }

            Console.WriteLine(Result);

            try                                             //将生成的四则运算写入文件
            {
                StreamWriter sw = new StreamWriter(@"F:\班级\subject.txt");
                sw.Write(Result);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Error Write");
            }
        }

        public static string Generator()               //生成器
        {

            string result = null;
            Random random = new Random();

            int Number = random.Next(0, 101);
            int op_count = random.Next(2, 4);
            result += Number;

            for (int i = 0; i < random.Next(2, 4); i++)
            {
                Number = random.Next(0, 101);
                op_count = random.Next(0, 4);
                result = result + Operator[op_count] + Number;
            }

            return result;
        }

        public static string Inspection(string str)                //检验四则运算是否合格
        {

            DataTable dt = new DataTable();
            object obj = dt.Compute(str, "");
            while (Convert.ToInt64(obj) < 0 || obj.ToString().Contains(".") || str.Contains("/0"))
            {
                str = Generator();
                obj = dt.Compute(str, "");
            }
            return str + "=" + obj.ToString();
        }

    }
}
