using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MingWork
{
    class Program
    {
        private static string[] operkey = { "+", "-", "*", "/" };
        private static string CreatThis()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            int numcount = random.Next(3, 5);
            for (int i = 0; i < numcount; i++)
            {
                stringBuilder.Append(random.Next(100));
                stringBuilder.Append(operkey[random.Next(4)]);
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }

        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter("question.txt");
            Console.Write("算术题数:");
            Stack<string> oper = new Stack<string>();
            Stack<string> num = new Stack<string>();
            Random random = new Random();
            int QuestionNum = Int32.Parse(Console.ReadLine());
            string str = "";
            string substr = "";
            int num_count = 0;//数字字符个数
            for (int j = 0; j <QuestionNum ; j++)
            {
                string question = CreatThis();
                str =question + "!";
                try
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        substr = str.Substring(i, 1);
                        if (computerUtil.judgenumber(substr))//if (数字）
                        {
                            if (num_count == 0)
                            {
                                num.Push(substr);
                            }
                            else
                            {
                                num_count--;
                            }
                            if (computerUtil.judgenumber(str.Substring(i + 1, 1)))
                            {
                                string temp = num.Pop();
                                temp += str.Substring(i + 1, 1);
                                num.Push(temp);
                                num_count++;
                            }
                        }
                        else if (computerUtil.juderoper(substr))
                        {
                            if (oper.Count >= 1)
                            {
                                int oper1 = computerUtil.judgeOperLEV(substr);
                                int oper2 = computerUtil.judgeOperLEV(oper.Peek());
                                if (oper1 > oper2)
                                {
                                    oper.Push(substr);
                                }
                                else
                                {
                                    for (; oper.Count > 0 && num.Count >= 2; oper.Pop())
                                    {
                                        string temp = substr;
                                        int oper3 = computerUtil.judgeOperLEV(substr);
                                        int oper4 = computerUtil.judgeOperLEV(oper.Peek());
                                        if (oper4 < oper3)
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            int temp1 = Convert.ToInt32(num.Peek());
                                            num.Pop();
                                            int temp2 = Convert.ToInt32(num.Peek());
                                            num.Pop();
                                            num.Push(computerUtil.operate(oper.Peek(), temp1.ToString(), temp2.ToString()).ToString());
                                        }
                                    }
                                    oper.Push(substr);
                                }
                            }
                            else
                                oper.Push(substr);
                        }
                        else if (substr == "!")//结束标志
                        {
                            for (; oper.Count > 0 && num.Count >= 2; oper.Pop())
                            {
                                int temp1 = Convert.ToInt32(num.Peek());
                                num.Pop();
                                int temp2 = Convert.ToInt32(num.Peek());
                                num.Pop();
                                num.Push(computerUtil.operate(oper.Peek(), temp1.ToString(), temp2.ToString()).ToString());
                            }
                        }
                    }
                    if(Int32.Parse(num.Peek())<0)
                    {
                        j--;
                        continue;
                    }
                    Console.WriteLine("第"+j+"题:    "+question+"="+num.Peek());
                    string result = "第" + j + "题:    " + question + "=" + num.Peek();
                    sw.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.Write("机算有错");
                }

            }
            sw.Flush();
            sw.Close();
            Console.ReadKey();
            
        }
    }
}
