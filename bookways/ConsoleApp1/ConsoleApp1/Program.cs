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
        public static string path = @"E:\hbw.txt";  //将n个算式写入E:\hbw
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("练习题数量：");
            n = Convert.ToInt32(Console.ReadLine());
            GetSubject(n);
        }

        static public void GetSubject(int n)
        {
            StreamWriter a = new StreamWriter(path);
            Random b= new Random();
            int[] num = new int[4];
            char[] ch = new char[3];
            for (int i = 0; i < n; i++)
            {
                int cnum = b.Next(2, 4);       //运算符个数
                num[cnum] = b.Next(101);
                double resultTest = num[0];     //用于检查结果是否为整数
                long result = num[0];
                string subject = num[0].ToString();  //代表算式的字符串
                for (int m = 0; m < cnum; m++)
                {
                    num[m] = b.Next(101);
                    int q = b.Next(4);
                    switch (q)
                    {
                        case 0:
                            ch[m] = '+'; break;

                        case 1:
                            ch[m] = '-'; break;

                        case 2:
                            ch[m] = '*'; break;

                        case 3:
                            ch[m] = '/'; break;

                        default:
                            break;
                    }
                    if (ch[m] == '/' && num[m] == 0)
                    {
                        m--;
                        continue;
                    }
                    switch (ch[m])
                    {
                        case '+':
                            resultTest = resultTest + (double)num[m]; break;

                        case '-':
                            resultTest = resultTest - (double)num[m]; break;

                        case '*':
                            resultTest = resultTest * (double)num[m]; break;

                        case '/':
                            resultTest = resultTest / (double)num[m]; break;

                        default:

                            break;
                    }
                    //检验resulttest是否为整数，若不是，重新循环。
                    if (resultTest != Convert.ToDouble(Convert.ToInt64(resultTest)))
                    {
                        m--;
                        continue;
                    }
                    switch (ch[m])
                    {
                        case '+':
                            result = result + num[m]; break;

                        case '-':
                            result = result - num[m]; break;

                        case '*':
                            result = result * num[m]; break;

                        case '/':
                            result = result / num[m]; break;

                        default:
                            break;
                    }
                    subject += ch[m] + num[m].ToString();
                }
                subject += "=" + result.ToString();
                a.WriteLine(subject);
            }
            a.Close();
            Console.WriteLine("已将算式写入:" + path);
            Console.ReadLine();
        }
    }
}