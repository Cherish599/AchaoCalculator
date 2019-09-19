using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入题目的数量：");
            int n = int.Parse(Console.ReadLine());
            char[] z = { '+', '-', '*', '/' };
            Random r = new Random();
            int p = 0;
            while(p<n)
            {
                int x = r.Next(2, 4);              //生成运算符的个数
                int num1 = r.Next(1, 100);          //生成题目的第一个数
                string s = num1.ToString();         //转化成字符类型
                for (int q = 0; q < x; q++)         //运算符个数来循环，产生长度不同的题目
                {
                    int y = r.Next(0, 4);          //随机生成0-3的数
                    s += z[y];                      //把随机生成的运算符加到字符串s后面
                    int num2 = r.Next(1, 100);      //随机生成1-99的数
                    s += num1.ToString();           //把随机生成的数加到字符串s后面
                }
                                                    //上述循环结束后，题目产生出来
                string result = Program.calculate(s);                       //调用静态方法
                if (result.Contains(".") || int.Parse(result) < 0)          //判断产生的字符串是否有小数点以及结果是否小于0
                {
                    continue;
                }
                else
                {
                    p++;
                    Console.WriteLine(s + "=" + result);                    //打印结果
                }
            }

        }
        public  static string calculate(string s)
        {
            object result = new DataTable().Compute(s, "");         //这里使用了封装的方法，可以直接计算上述字符串的值，算出的值默认为object对象
            string y = result.ToString();                           //这里要拆箱，把object对象转化为string对象，便于后面用于判断
            return y;   
        }
    }
}   
