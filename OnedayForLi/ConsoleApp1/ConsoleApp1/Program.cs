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
            //定义式子
            string equation ="";  
            //设置初始值
            int OpRight;
            int op = 0;
            //决定有几个运算符
            int OpNumber = random.Next(2, 4);
            //操作数一定比运算符多一个，所以循环的总数是(2*OpNumber)+1
            for (int i = 0; i <(2*OpNumber)+1; i++) 
            {
                //当循环到偶数的时候，是数字
                if (i % 2 == 0)                     
                {
                    OpRight = random.Next(0, 101);
                    equation += OpRight;
                }
                //当循环到奇数的时候，是运算符
                else
                {                                   
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
            //将对象转换成字符串的形式，如果其中有"-"".""/0"则不满足条件，重新调用
            while (obj.ToString().Contains("-") || obj.ToString().Contains(".") || str.Contains("/0"))
            {
                str = create();
                obj = dt.Compute(str, "");
            }
            //计算结果加入str，形成完整算式
            str = str + "=" + obj.ToString();
            return str;
        }
        //写入文件的函数
        public static void Writefile(string result)
        {
            //创建文件
            StreamWriter sw = File.AppendText(@"C:\Users\李星晨\Desktop\第二次作业\AchaoCalculator\test.txt");
            //写入函数结果
            sw.WriteLine(result);
            sw.Flush();
            //关闭文件
            sw.Close();
        }

        public static void Main(string[] args)
        {
            string result;
            Console.Write("请输入题目个数：");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //调用一次创建函数
                string equation = create();
                //计算创建的式子的结果
                result = Count(equation);
                //输出结果
                Console.WriteLine(result);
                //random在不加种子的情况下，默认使用系统的时针，出现的数字总是会相同，所以让它休眠一会
                System.Threading.Thread.Sleep(50);
                //写入文件部分是保存在本地，逐次调用导致路径出错会导致后续程序无法正常运行，故注释掉，结果已在博客园中写明。
                //Writefile(result);
            }
            //方便观察，防止退出
            Console.Read();                                    

        }
    }
}
