using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Colotu
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            method md = new method();
            char[] e = new char[4] { '+', '-', '*', '/' };

            Console.WriteLine("输入一个数目按回车结束");

            int a = Convert.ToInt32(Console.ReadLine());
            
            for(int b=0;b<a;b++)
            {
                Random c = new Random();
                int d = c.Next(2, 4);
                int[] f = new int[4];
                int[] g = new int[3];

                f[0] = c.Next(0, 101);
                int parm = f[0];
                //d是运算符个数

                int tru = 1;
                for (int h=0;h<d;h++)
                {
                    
                    g[h] = c.Next(0, 4);
                    
                    
                    switch(g[h])
                    {
                        case 0: f[h+1] = c.Next(0, 101); if ((md.Result(f, g, h) < 0)&&(h!=0)) tru = 0; parm = f[h + 1]; break;
                        case 1: f[h+1] = c.Next(0, 101); if ((md.Result(f, g, h) < 0)&&(h!=0 ))tru = 0; parm = f[h + 1];  break;
                            //上面要检验正负
                        case 2: f[h+1] = c.Next(0, 101); parm *= f[h + 1]; break;
                        case 3: f[h+1] = md.Resr(parm); parm /= f[h + 1]; break;
                    }
                    if (tru == 0)
                        break;
                }
                int sum;
                sum = md.Result(f, g, d);
                if ((tru == 1)&&(sum>=0))
                {
                    



                    System.Text.StringBuilder sb = new System.Text.StringBuilder();

                    sb.Append(f[0]);

                    sb.Append(e[g[0]]);

                    sb.Append(f[1]);
                    sb.Append(e[g[1]]);
                    sb.Append(f[2]);

                    if (d == 3)
                    {

                        sb.Append(e[g[2]]);
                        sb.Append(f[3]);
                    }
                    sb.Append('=');
                    sb.Append(sum);
                    string str = sb.ToString();
                    Console.WriteLine(str);
                    //输入到文件中
                    string s = "G:/08test/subject.txt";
                    StreamWriter sw = new StreamWriter(@s, true);//true表示追加

                    sw.WriteLine(str);
                    sw.Flush();
                    sw.Close();
                }
                else
                    b--;
            }
            
        }
    }
}
