using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ConsoleApp1
{
    
     public class Program
    {
        class Func
        { 
            public string Getrandom(string[] arr)
            {
                Random ad = new Random();
                int op = ad.Next(arr.Length - 1);
                return arr[op];
            }

            public int Getnum(int m, int[] numstore)
            {
                int i = m;
                Random ad = new Random();
                int num = ad.Next(0, 101);
                numstore[i] = num;
                for (int j = 0; j < i; j++)
                {
                    if (num == numstore[j])
                        return Getnum(m, numstore);
                }
                return num;
            }
            //生成四则运算
            public string func()
            {
                string[] arr = new string[] { "/", "+", "-", "*", "" };
                int operation;//运算符个数
                int num1;//第一个数
                int num2;//之后的随机数
                string result = null;//四则运算式
                int m = 0;
                int[] numstore = new int[100];//临时存储生成的随机数
                Random ad = new Random();
                operation = ad.Next(2, 4);
                num1 = Getnum(m, numstore);
                m++;//临时存储生成的随机数+1
                result = num1.ToString();
                for (int i = 1; i <= operation; i++)
                {
                    num2 = Getnum(m, numstore);
                    m++;
                    result = result + Getrandom(arr) + num2.ToString();
                }
                return result;

            }
            //验算四则运算并将其变为合格的等式
            public string Vilidate(string calculation)
            {
                DataTable dt = new DataTable();
                object nnn = dt.Compute(calculation, null);
                //这里的“-”用于判断是否为负数，“/0”除零操作，“.”表示为小数
                while (nnn.ToString().Contains(".") || nnn.ToString().Contains("-") || calculation.ToString().Contains("/0"))
                {
                    calculation = func();
                    nnn = dt.Compute(calculation, null);
                }
                //返回等式，calculation为之前生成的等式，nnn为结果
                return calculation + "=" + nnn.ToString();
            }
            //写入subject文档

            public void Write(string result)
            {
                try
                {
                    StreamWriter swer = new StreamWriter("D:\\subject.txt", true);
                    swer.WriteLine(result);
                    swer.Close();
                }
                catch
                {
                    Console.WriteLine("保存出错了~");
                }
            }

            //单元测试
            /*public static bool Write(string result)
            {
                try
                {
                    StreamWriter swer = new StreamWriter("D:\\subject.txt", true);
                    swer.WriteLine(result);
                    swer.Close();
                return true;
                }
                catch
                {
                    Console.WriteLine("保存出错了~");
                return false;
                }
            }*/

        }
        //主函数
        static void Main(string[] args)
        {
            Console.WriteLine("那么接下来你想要打印出多少道题目：");
            //print_num表示打印题目的数目
            int print_num = int.Parse(Console.ReadLine());
            for (int i = 0; i < print_num; i++)
            {
                //如果要进行代码的运行需要把后面的注释解除
                Func aa = new Func();
               string bb = aa.func();//创建等式
               string result = aa.Vilidate(bb);//验证等式
               aa.Write(result);//写入等式

                //Program aa = new Program();
                //string bb = aa.func();
                //string result = aa.Vilidate(bb);
                //aa.Write(result);


                Console.WriteLine(result);//打印出结果
            }
            Console.ReadKey();
        }
    }
}
