using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
     public class Program
    {
        static void Main(string[] args)
        {
            /*int i,j,flag=1;
            if (flag == 0)
            {
                for (i = 1; i < 10; i++)
                {
                    for (j = 1; j <= i; j++)
                    {
                        Console.Write(j + "*" + i + "=" + j * i + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("error");
            }*/
            for(int i = 1; i < 100000; i++)
            {
                Console.WriteLine("error");
            }
        }

        public static int add(int x, int y)     //加法
        {
            return x+y;
        }

        public static double sub(double x, double y)      //减法
        {
            return x - y;
        }

        public static Boolean judge(int x, int y)    //判断大小
        {
            if (x > y)
                return true;
            else
                return false;
        }




    }
}
