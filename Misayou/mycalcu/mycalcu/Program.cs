using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Microsoft.Vsa;
using Microsoft.JScript;

namespace mycalcu
{
    class Program
    {
        /**
         * 判断用户输入的题目数量是否是正确的
         * */
        public static Boolean judgeInput(int times)
        {
            if (times >= 0)
            {
                int temp = (int)times;
                if (temp == times)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /**
         * 判断一个数是否为质数
         * */
         public static int jugdeZhishu(int x)
         {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                    return 1;
            }
            return 0;
        }

        /**
         * 计算产生式子的值
         * */
        public static object CalcByJs(string expression)
        { 
            Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
            object returnValue = Microsoft.JScript.Eval.JScriptEvaluate((object)expression,ve);
            return returnValue;
        }

        /**
         * 将产生的式子和结果存入E:\Software\test.txt
         * */
        public static void printfFile(string msg)
        {
            string path = @"E:\Software\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter sw = fileInfo.AppendText();
            sw.WriteLine(msg);
            sw.Flush();
            sw.Close();   
        }
        

        static void Main(string[] args)
        {
            
            Console.Write("请输入你想要做的题目数量:");
            int times = int.Parse(Console.ReadLine());
            if (judgeInput(times) == true)
            {
                char[] op = new char[] { '+', '-', '*', '/' };
                Random random = new Random();
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < times; i++)
                {
                    int symbol = (int)random.Next(1) + 2;
                    int[] number = new int[symbol + 1];
                    int flag = 1;
                    String expression = null;
                    for (int j = 0; j <= symbol; j++)
                    {
                        number[j] = (int)random.Next(1, 101);
                    }
                    for (int k = 0; k < symbol; k++)
                    {
                        int s = (int)random.Next(4);
                        if(flag%2==0&&s==3)
                        {
                            s = (int)random.Next(3);
                        }
                        if(s==3)
                        {
                            flag--;
                            while(number[k]%number[k+1]!=0)
                            {
                                if(jugdeZhishu(number[k])==0&&number[k]!=number[k+1])
                                {
                                    number[k] = (int)random.Next(1, 101);
                                }
                                else if(jugdeZhishu(number[k])==1)
                                {
                                    number[k+1] = (int)random.Next(1, 101);
                                }
                            }
                        }
                        expression += string.Concat(number[k].ToString(), op[s].ToString());
                    }
                    expression += number[symbol].ToString();
                    int result = System.Convert.ToInt32(CalcByJs(expression));
                    if (result > 0)
                    {
                        arrayList.Add(expression);
                        string Fresult = expression + "=" + CalcByJs(expression);
                        Console.WriteLine(Fresult);
                        printfFile(Fresult);
                    }
                    else
                    {
                        i--;
                    }

                }
            }
            else
            {
                Console.Write("请输入你想要做的题目数量:");
            }
        }
    }
}
