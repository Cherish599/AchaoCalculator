using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        //创建式子的函数
        public static string create()
        {
            Random random = new Random();
            string equation ="";                   //定义式子
            int OpLeft = 0;
            int OpRight = 0;
            int op = 0;
            int OpNumber = random.Next(2, 4);       //决定有几个运算符
            OpLeft = random.Next(0, 101);
            //equation += OpLeft;
            for (int i = 0; i <(2*OpNumber)+1; i++) //操作数一定比运算符多一个，所以总数是
            {
                if (i % 2 == 0)                     //当循环到偶数的时候，是数字
                {
                    OpRight = random.Next(0, 101);
                    equation += OpRight;
                }
                else
                {                                   //当循环到奇数的时候，是运算符
                    op = random.Next(0, 4);
                    equation += FuHao(op);
                }
            }
            return equation;
        }
        //用随机数来创造符号的函数
        public static string FuHao(int number) {
            string symbol="";
            switch (number)
            {
                case 0:
                    symbol= "+";
                    break;
                case 1:
                    symbol = "-";
                    break;
                case 2:
                    symbol = "*";
                    break;
                case 3:
                    symbol = "/";
                    break;
            }
            return symbol;
        }
        //对创建出的方程式进行计算的函数
        public static string Count(string str) {   

            DataTable dt = new DataTable();  
            object obj = dt.Compute(str, "");
            while (obj.ToString().Contains("-") || obj.ToString().Contains(".") || str.Contains("/0"))
            {
                str = create();
                obj = dt.Compute(str, "");
            }
            return str+"="+ obj.ToString();
        }
        //写入文件的函数
        public static void Writefile(string result)
        {
            StreamWriter sw = File.AppendText(@"C:\Users\李星晨\Desktop\第二次作业\AchaoCalculator\test.txt");
            sw.WriteLine(result);
            sw.Flush();
            sw.Close();
        }

        public static void Main(string[] args)
        {
            string result;
            Console.Write("请输入题目个数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string equation = create();
                result = Count(equation);
                Console.WriteLine(result);
                System.Threading.Thread.Sleep(50);        //random在不加种子的情况下，使用系统的时针，出现的数字总是会相同，所以让它休眠一会
                Writefile(result);
            }
            Console.Read();                                    

        }
    }
}
