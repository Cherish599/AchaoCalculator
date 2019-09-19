using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace AchaoCalculator
{
    public class Program
    {
        //主函数
        public static void Main(string[] args)
        {
            calculator();
            Console.ReadKey();
        }

        //运算符字符数组
        public static char[] Operator = { '+', '-', '*', '/' };

        //生成等式
        public static string formula()
        {
            int opNumber = 0;
            int firstNum = 0;
            int nextNum = 0;
            int opNum = 0;

            string result = null;
            Random rd = new Random();

            firstNum = (int)rd.Next(0, 101);
            opNumber = (int)rd.Next(2, 4);
            result += firstNum;

            for (int i = 0; i < opNumber; i++)
            {
                nextNum = (int)rd.Next(0, 101);
                opNum = (int)rd.Next(0, 4);
                result = result + Operator[opNum] + nextNum;
            }

            return result;
        }

        //求解生成的等式，调用Computer函数
        public static string Solve(string msg)
        {
            DataTable dt = new DataTable();
            object ob = null;
            ob = dt.Compute(msg, "");
            //不能出现小数和除0操作，若出现则重新生成
            while (ob.ToString().Contains(".") || msg.Contains("/0") || Convert.ToInt32(ob) < 0) 
            {
                msg = formula();
                ob = dt.Compute(msg, "");
            } 
            return msg + "=" + ob.ToString();
        }

        //打印计算结果
        public static void calculator()
        {
            int countNumber = 0;
            string finalResult = null;

            Console.Write("请输入生成题的数目:");
            countNumber = int.Parse(Console.ReadLine());


            for (int i = 0; i < countNumber; i++)
            {
                finalResult += Solve(formula()) + "\r\n";
                //延时50ms，使随机种子变化
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine(finalResult);
            //写出生成的等式
            Fwrite(finalResult);
        }

        //写入文件到记事本
        public static bool Fwrite(String msg)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\软件工程\AchaoCalculator\sunmying.txt");
                sw.Write(msg);
                sw.Close();
                return true;
            }
            catch
            {
                Console.WriteLine("保存文本文件出错！");
                return false;
            }
        }
    }
}
