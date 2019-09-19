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
        public static string path = @"D:\Program Files (x86)\Git\第二次作业\AchaoCalculator\LuckyMickey\LuckyMickey生成结果.txt"; 
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please enter the number of exercises：");
            n = Convert.ToInt32(Console.ReadLine());
            GetSubject(n);
        }

        static public void GetSubject(int n)
        {
            StreamWriter sw = new StreamWriter(path);
            Random rdm = new Random();
            int[] num = new int[4];
            char[] ch = new char[3];
            for (int i = 0; i < n; i++)
            {
                int cnum = rdm.Next(2, 4); 
                num[cnum] = rdm.Next(101);
                double resultTest = num[0]; 
                long result = num[0];
                string subject = num[0].ToString(); 
                for (int m = 0; m < cnum; m++)
                {
                    num[m] = rdm.Next(101);
                    int r = rdm.Next(4);
                    switch (r)
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
                sw.WriteLine(subject);
            }
            sw.Close();
            Console.WriteLine("已将算式写入:" + path);
            Console.ReadLine();
        }
    }
}