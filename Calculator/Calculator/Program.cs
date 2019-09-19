using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("请输入题目数：");
            int num=Convert.ToInt32(Console.ReadLine());//设计题目数量
            Random rand = new Random();
            for(int i=0;i<num;i++)
            {
                string str1;
                string str2;
                string str3;
                string str4;
                string finalstr;
                StringBuilder mystring = new StringBuilder();
                int figure1 = rand.Next(1, 100);
                int figure2 = rand.Next(1, 100);
                int figure3 = rand.Next(1, 100);
                utils u = new utils();
                symbol sym = new symbol();
                yunsuan y = new yunsuan();
                string sym1 = sym.randSymbol(rand.Next(1, 5));
                string sym2 = sym.randSymbol(rand.Next(1, 5));
                if (y.Sum(figure1, figure2, figure3, sym1, sym2) < 0 || u.judge(sym1, sym2, figure1, figure2, figure3)==false)
                {
                    i--;
                    continue;
                }
                else
                {
                    Console.Write(figure1);
                    Console.Write(sym1);
                    Console.Write(figure2);
                    Console.Write(sym2);
                    Console.WriteLine(figure3 + "=" + y.Sum(figure1, figure2, figure3, sym1, sym2));
                }
                str1 = figure1.ToString();
                str2 = figure2.ToString();
                str3 = figure3.ToString();
                str4 = y.Sum(figure1, figure2, figure3, sym1, sym2).ToString();
                mystring.Append(str1);
                mystring.Append(sym1);
                mystring.Append(str2);
                mystring.Append(sym2);
                mystring.Append(str3);
                mystring.Append("=");
                mystring.Append(str4);
                finalstr = mystring.ToString();
                StreamWriter stream = new StreamWriter("test.txt", true);
                stream.WriteLine(finalstr);
                stream.Close();
            }
        }
    }
}
