using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("请输入题目数量：");
          int  n = Convert.ToInt32(Console.ReadLine());
            jishiben(n);//将算式写入记事本
        } 
        public statica void jishiben(int n)
        {
           
            Random sju = new Random();
            int[] suzi = new int[4];
            char[] b = new char[3];
            string ji = @"D:\Yunsuanshi.txt";
            StreamWriter st = new StreamWriter(ji);
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(250);
                int cnum = sju.Next(2, 4);       //随机运算符个数
                suzi[cnum] = sju.Next(1,100);
               
                double jieguo = suzi[0];
                string subject = suzi[0].ToString();  //运算式的字符串
               
                for (int h = 0; h < cnum; h++)//将随机数与运算符号匹配
                {
                    suzi[h] = sju.Next(0,100);
                    int r = sju.Next(0,4);
                    switch (r)
                    {
                        case 0:
                            b[h] = '+'; break;
                        case 1:
                            b[h] = '-'; break;
                        case 2:
                            b[h] = '*'; break;
                        case 3:
                            b[h] = '/'; break;
                       
                    }
                    if (b[h].ToString().Contains("/0"))//判断运算式是否出现小数
                    {
                        h--;
                        continue;
                    }
                  
                  //通过运算符号与结果相连
                    switch (b[h])
                    {
                        case '+':
                            jieguo = jieguo + suzi[h];
                            break;
                        case '-':
                            jieguo = jieguo - suzi[h];
                            break;
                        case '*':
                            jieguo = jieguo * suzi[h];
                            break;
                        case '/':
                            jieguo = jieguo / suzi[h];
                            break;
                       
                    }
                   subject += suzi[h].ToString()+ b[h] ;
                }
                subject += "=" + jieguo.ToString();
                st.WriteLine(subject);
            }
            st.Close();
            Console.WriteLine("题目写入:" + ji);//将题目写入记事本
            Console.ReadLine();
        }
    }
}
