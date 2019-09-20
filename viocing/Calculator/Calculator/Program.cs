using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Calculator
{

   public class jisuan
    {
        int symbolnum;//符号个数
                      //生成一个具体的等式
        public string setequal()
        {
            string s = null;//用以记录最后生成算术题
            int figure;//随机生成的数字
            string symbol;//随机生成的符号
            int n;//用以判断生成的符号
            int i;
            //采用Random类
            Random rd = new Random(Guid.NewGuid().GetHashCode());//使用Guid的哈希码作为种子值
            symbolnum = rd.Next(2, 4);//随机生成符号个数在2个到3个之间
            figure = rd.Next(0, 101);//产生的一个数
            s = s + figure.ToString();//先接上第一个数字
            for (i = 0; i < symbolnum; i++)
            {
                n = rd.Next(1, 5);//随机产生符号编号
                symbol = Sybx(n);//翻译成符号
                s = s + symbol;
                figure = rd.Next(0, 101);
                s = s + figure.ToString();
            }
            return s;
        }
        public string Sybx(int num)//判断符号
        {
            if (num == 1)
            {
                return "+";
            }
            if (num == 2)
            {
                return "-";
            }
            if (num == 3)
            {
                return "*";
            }
            if (num == 4)
            {
                return "/";
            }
            else
            {
                return "";
            }
        }
        //计算函数
        public string result(string s)
        {
            DataTable dt = new DataTable();
            return dt.Compute(s, "false").ToString();
        }
    }
    public class fun
    {
        public string cv(string equation)
        {
            jisuan x = new jisuan();
            int u;//判断是否分母为0
            int nm;
            int weizhi = 0;
            string last = null;//最终产生的结果
            string rt = null;//计算结果字符串
            u = equation.IndexOf("\0");//不能出现分母为0的情况
            if (u == -1)
            {
                rt = x.result(equation);
                weizhi = rt.IndexOf(".");//不能出现结果为小数的情况
                if (weizhi == -1)
                {
                    last = equation + "=" + rt;
                    return last;
                }
                else
                {
                    return " ";
                }
            }
            else
            {
                return " ";
            }

        }
    }


   class Program
    {
        static void Main(string[] args)
        {
            string bg = null;
            string h = null;
            string equation = null;//产生的式子
            int nm = int.Parse(Console.ReadLine());//输入生成的算式的个数
            fun f = new fun();                           //Console.WriteLine(nm.ToString());
            for (int i = 0; i < nm; i++)
            {
                jisuan x = new jisuan();
                equation = x.setequal();
                bg = f.cv(equation);
                if (bg != " ")
                {
                    h = h + bg + "\r\n";
                }
                else
                {
                    i--;
                    continue;
                }
            }
            Console.WriteLine(h);
            System.IO.File.WriteAllText("E:/subject.txt", h, Encoding.Default);
            Console.ReadKey();
        }
    }
}