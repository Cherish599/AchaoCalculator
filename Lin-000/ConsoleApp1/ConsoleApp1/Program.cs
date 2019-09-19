using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Create
    {
        public string Answer(string s)
        {
            DataTable dt = new DataTable();
            string result = dt.Compute(s, "false").ToString();
            return result;
        }
        public int Check(string s1, string s2)
        {
            if (!s1.Contains("/0") && !s2.ToString().Contains("."))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public void Title(int n)   // 生成等式题目
        {
            Random rd = new Random();
            string[] S = { "+", "-", "*", "/" };
            for (int i = 0; i < n; i++)
            {
                int opNum = rd.Next(3, 4); // 运算符个数
                int num1 = rd.Next(1, 101); // 第一个数
                string str = null;
                str += num1;
                for (int j = 0; j < opNum; j++)
                {
                    string temp_result;
                    int num2 = rd.Next(1, 101);
                    int opNumber = rd.Next(0, 4); // 运算符数组下标
                    str += S[opNumber] + num2; // str为等式字符串
                    temp_result = Answer(str);
                    // temp_result保存临时结果，等式符合要求时，temp_result为等式最后答案
                    if (temp_result.ToString().Contains("-"))
                    {
                        str = null;
                        str += num1;
                        j = 0;
                    }
                }
                string final_result = Answer(str);
                if (Check(str, final_result) == 2)
                {
                    i--;
                }
                else
                {
                    Console.Write(str + "=");
                    Console.WriteLine(final_result);
                }
            }
        }
    }
}
class Program
{

    static void Main()
    {
        Console.Write("需要的题目数为：");
        Create c = new Create();
        int n = int.Parse(Console.ReadLine());
        c.Title(n);
        StreamWriter sw = new StreamWriter(@"D:\subject.txt");
        Console.SetOut(sw);
        Console.WriteLine("需要生成的题目数为:" + n);
        c.Title(n);
        sw.Flush();
        sw.Close();
    }
}
