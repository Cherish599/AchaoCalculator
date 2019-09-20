using System;
using System.Data;
namespace ConsoleApp1
{
    public class Inputs
    {
        public static string Operation()
        {
            char[] O = { '+', '-', '*', '/' };//将运算符载入数组中          
            Random ra = new Random();//生成随机数
            int a = ra.Next(0, 100);
            int num = ra.Next(2, 4);
            string result = null;
            result = result + a;
            for (int y = 0; y < num; y++)
            {
                int o = ra.Next(0, 4);//在这四个数中随机，实现运算符的随机
                int b = ra.Next(0, 100);
                if (O[o] == '/')
                {
                    if (b != 0)
                        result = result + O[o] + b;
                    else
                        break;
                }
                else
                    result = result + O[o] + b;

            }
            return result;

        }
        public static string R(string T)
        {
            object ob = null;
            DataTable dt = new DataTable();
            ob = dt.Compute(T, "");
            while (ob.ToString().Contains(".") || int.Parse(ob.ToString()) < 0)//判断四则运算是否符合题目要求
            {
                T = Operation();
                ob = dt.Compute(T, "");//再次检验是否合乎要求
            }
            return T + "=" + ob.ToString();
        }

    }
}