using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\软工作业\AchaoCalculator\shisan9527\zx.txt");
            int NumOfSymbol;
            DataTable dataTable = new DataTable();
            Console.WriteLine("输入一个整数确定四则运算个数，请输入：");
            int count = Convert.ToInt32(Console.ReadLine());
            String[] symbol = { "+", "-", "*", "/" };
            Random r = new Random();

            Console.SetOut(sw);
            for (int j = 1; j <= count; j++)
            {

                int num = r.Next(1, 101);
                if (num > 50)
                {
                    NumOfSymbol = 2;
                    int tmp = 0;
                    List<string> list1 = new List<string>();
                    while (true)
                    {

                        int NumOfArr = r.Next(0, 4);
                        string result = symbol[NumOfArr];
                        list1.Add(result);
                        tmp++;

                        if (tmp == NumOfSymbol)
                        {
                            string a = Convert.ToString(r.Next(1, 101));
                            string b = Convert.ToString(r.Next(1, 101));
                            string c = Convert.ToString(r.Next(1, 101));

                            string formula = String.Concat(a, list1[0], b, list1[1], c);
                            object test = dataTable.Compute(formula, "");
                            decimal final = Convert.ToDecimal(test);
                            int finalNum = Convert.ToInt32(final);
                            if (final == finalNum && final > 0)
                            {
                                if (list1[0].Equals("/") || list1[1].Equals("/"))
                                {
                                    if (Convert.ToInt32(a) < Convert.ToInt32(b) && Convert.ToInt32(b) < Convert.ToInt32(c))
                                    {
                                        tmp = 0;
                                        list1.Clear();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(a + list1[0] + b + list1[1] + c + "=" + final);

                                    break;
                                }

                            }
                            else
                            {
                                tmp = 0;
                                list1.Clear();
                            }

                        }
                    }
                }
                else
                {
                    NumOfSymbol = 3;
                    int tmp = 0;
                    List<string> list2 = new List<string>();
                    while (true)
                    {
                        int NumOfArr = r.Next(0, 4);
                        string result = symbol[NumOfArr];
                        list2.Add(result);
                        tmp++;
                        if (tmp == NumOfSymbol)
                        {
                            string a = Convert.ToString(r.Next(1, 101));
                            string b = Convert.ToString(r.Next(1, 101));
                            string c = Convert.ToString(r.Next(1, 101));
                            string d = Convert.ToString(r.Next(1, 101));
                            string formula = String.Concat(a, list2[0], b, list2[1], c, list2[2], d);
                            object test = dataTable.Compute(formula, "");
                            decimal final = Convert.ToDecimal(test);
                            int finalNum = Convert.ToInt32(final);

                            if (final == finalNum && final > 0)
                            {
                                if (list2[0].Equals("/") || list2[1].Equals("/") || list2[2].Equals("/"))
                                {
                                    if (Convert.ToInt32(a) < Convert.ToInt32(b) || Convert.ToInt32(b) < Convert.ToInt32(c) || Convert.ToInt32(c) < Convert.ToInt32(d))
                                    {
                                        tmp = 0;
                                        list2.Clear();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(a + list2[0] + b + list2[1] + c + list2[2] + d + "=" + final);
                                    break;
                                }

                            }
                            else
                            {
                                tmp = 0;
                                list2.Clear();
                            }
                        }
                    }
                }
            }
            sw.Flush();
            sw.Close();
        }
    }
}
