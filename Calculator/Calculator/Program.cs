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
                int thrfour = rand.Next(0, 2);
                if (thrfour == 0)
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
                    if (y.Sum(figure1, figure2, figure3, sym1, sym2) < 0 || u.judge1(sym1, sym2, figure1, figure2, figure3) == false)
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
                else
                {
                    string str1;
                    string str2;
                    string str3;
                    string str4;
                    string str5;
                    string finalstr;
                    StringBuilder mystring = new StringBuilder();
                    symbol sym1 = new symbol();
                    yunsuan y1 = new yunsuan();
                    utils u = new utils();
                    int f1=rand.Next(1,100);
                    int f2 = rand.Next(1, 100);
                    int f3 = rand.Next(1, 100);
                    int f4 = rand.Next(1, 100);
                    string s1 = sym1.randSymbol(rand.Next(1, 5));
                    string s2 = sym1.randSymbol(rand.Next(1,5));
                    string s3 = sym1.randSymbol(rand.Next(1,5));
                    if(y1.Sumfour(f1,f2,f3,f4,s1,s2,s3)<0||u.judge2(s1,s2,s3,f1,f2,f3,f4)==false)
                    {
                        i--;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(f1 + s1 + f2 + s2 + f3 + s3 + f4 + "=" + y1.Sumfour(f1, f2, f3, f4, s1, s2, s3));
                    }
                    str1 = f1.ToString();
                    str2 = f2.ToString();
                    str3 = f3.ToString();
                    str4 = f4.ToString();
                    str5 = y1.Sumfour(f1, f2, f3, f4, s1, s2, s3).ToString();
                    mystring.Append(str1);
                    mystring.Append(s1);
                    mystring.Append(str2);
                    mystring.Append(s2);
                    mystring.Append(str3);
                    mystring.Append(s3);
                    mystring.Append(str4);
                    mystring.Append("=");
                    mystring.Append(str5);
                    finalstr = mystring.ToString();
                    StreamWriter stream = new StreamWriter("test.txt", true);
                    stream.WriteLine(finalstr);
                    stream.Close();
                }
            }
        }
    }
}
