using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace calculator
{
    public class calcu
    {
        public int[] op_num=new int[4];//操作数
        public char[] op_sy = new char[3];//操作符
        int n_length = 0;
        int s_length = 0;
        public int sum = 0;

        public calcu()
        {
           
        }
        
        public calcu(int[] a,char[] b)//构造函数
        {
            
            for (int i=0;i<a.Length;i++)//操作数初始化
            {
                op_num[i] = a[i];
                n_length++;
            }
            
            for(int j=0;j<b.Length;j++)//操作符初始化
            {
                op_sy[j] = b[j];
                s_length++;
            }
        }

        public bool calaclate1()
        {
            
            for(int i=0;i<s_length;)
            {
                switch (op_sy[i])
                {
                    case '*':
                        int m,n;
                        op_num[i] = op_num[i] * op_num[i + 1];
                        for(m=i+1;m<n_length-1;m++)//移操作数
                        {
                            op_num[m] = op_num[m + 1];
                        }
                        op_num[m] = 0;
                        for(n=i;n<s_length-1;n++)//移操作符
                        {
                            op_sy[n] = op_sy[n + 1];
                        }
                        op_sy[n] = '+';
                        break;
                    case '/':
                    
                        if ((int)(op_num[i]/(op_num[i+1]*1.0))!= (op_num[i] / (op_num[i + 1] * 1.0)))//判断是否为整数
                        {
                            return false;
                        }
                        else
                        {
                            int p, q;
                            op_num[i] = op_num[i] / op_num[i + 1];
                            for (p = i + 1; p < n_length - 1; p++)
                            {
                                op_num[p] = op_num[p + 1];
                            }
                            op_num[p] = 0;
                            for (q = i; q < s_length - 1; q++)
                            {
                                op_sy[q] = op_sy[q + 1];
                            }
                            op_sy[q] = '+';

                        }
                        break;
                    default:
                        i++;
                        break;
                }
            }
            return true;
        }
        public int calculate2()
        {
            sum = op_num[0];
            for(int i=0;i<s_length;i++)
            {
                switch(op_sy[i])
                {
                    case '+':
                        sum += op_num[i + 1];
                        break;
                    case '-':
                        sum -= op_num[i + 1];
                        break;

                }
            }
            return sum;
        }
    }
    class Program
    {
        private static object thread;

        
        

        static void Main(string[] args)
        {
            Console.Write("希望输出多少道题目：");
            int q_num = int.Parse(Console.ReadLine());
            List<string> str1 = new List<string>();
            
            char[] temp = { '+', '-', '*', '/' };
            
            for (int i=1;i<=q_num;)
            {
                
                Random r = new Random();
                int[] a = new int[4];
                char[] b = new char[3];
                int rn = r.Next(2, 4);//随机产生操作符个数，根据操作符个数随机产生操作数和操作符
                for(int j=0;j<=rn;j++)//产生操作数
                {
                    a[j] = r.Next(1,100);
                    Thread.Sleep(10);
                }
                
                for(int p=0;p<rn;p++)//产生操作符
                {
                    int cn = r.Next(0,4);
                    Thread.Sleep(100);
                    b[p] = temp[cn];
                }
                calcu cl_tor = new calcu();
                
                cl_tor = new calcu(a, b);
                if(cl_tor.calaclate1())
                {
                    string str = a[0].ToString();
                    Console.Write("{0}", a[0]);
                    for(int q=0;q<rn;q++)
                    {
                        str = str + b[q].ToString()+a[q+1].ToString();
                        Console.Write("{0}{1}", b[q],a[q+1]);
                    }
                    str = str + "="+cl_tor.calculate2().ToString();
                   Console.WriteLine("={0}", cl_tor.calculate2());
                    i++;

                    str1.Add(str);
                }
               

            }
            File.WriteAllLines("calculator.txt", str1);
        }
    }
}
