using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator ca = new calculator();
            string s = null;
            Console.WriteLine("----------------------------------------四则运算题目-----------------------------------------");
            Console.WriteLine("请输入题目个数：");
            int x;
            x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                s = s + calculator.Y(calculator.X()) + "\n";
                System.Threading.Thread.Sleep(100);//语句的用法可以参考csdn博客https://bbs.csdn.net/topics/270030440
            }
            Console.WriteLine(s);
            Console.ReadKey();
            StreamWriter sw = new StreamWriter("D:\\Git\\新建文件夹\\subject.txt");
            sw.Write(s);
            sw.Close();//参考https://www.cnblogs.com/arxive/p/6781858.html上写入文档的用法
        }
    }
    class calculator
    {
        public static char[] fuhao = { '+', '-', '*', '/' };//将所用的符号放入数组
        public static string X()
        {
            string s = null;
            Random r = new Random();
            int num1 = r.Next(0, 100);
            int num2 = r.Next(2, 4);
            s = s + num1;
            for (int i = 0; i < num2; i++)
            {
                int num3 = r.Next(0, 100);
                int ff = r.Next(0, 4);
                s = s + fuhao[ff] + num3;//通过数组和随机0~3的数字来确定符号
            }
            return s;
        }
        public static string Y(string Q)
        {
            object ob = null;
            DataTable dt = new DataTable();
            //改进后的代码
            ob = dt.Compute(Q, "");
            while (ob.ToString().Contains(".") || Q.Contains("/0") || int.Parse(ob.ToString()) < 0)//判断四则运算是否符合题目要求
            {
                Q = X();
                ob = dt.Compute(Q, "");//再次检验是否合乎要求
            }
            return Q + "=" + ob.ToString();//最后返回结果
        }
    }
}