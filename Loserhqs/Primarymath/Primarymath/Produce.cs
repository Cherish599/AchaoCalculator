using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primarymath
{
    public class Produce
    {
        //存放运算符号的数组
        public static char[] oper = new char[4] { '+', '-', '*', '/' };
        public static void produce(int n)
        {
            int i=0;
            //有n道题
            while(i<n)
            {
                //生成两个或三个运算符的题目
                int type = Rand.rand.Next(0, 2);
                if (type == 0)
                {
                    //随机生成三个数
                    int num1 = Rand.rand.Next(0, 100);
                    int num2 = Rand.rand.Next(0, 100);
                    int num3 = Rand.rand.Next(0, 100);
                    //随机生成两种运算符号
                    int index1 = Rand.rand.Next(0, 4);
                    int index2 = Rand.rand.Next(0, 4);
                    int flag=Opterator.optwo(num1, num2, num3, index1, index2, Produce.oper);
                    if(flag==1)
                    {
                        i++;
                    }
                }
                else
                {
                    //随机生成四个数
                    int num1 = Rand.rand.Next(0, 10);
                    int num2 = Rand.rand.Next(0, 100);
                    int num3 = Rand.rand.Next(0, 100);
                    int num4 = Rand.rand.Next(0, 100);
                    //随机生成三种运算符号
                    int index1 = Rand.rand.Next(0, 4);
                    int index2 = Rand.rand.Next(0, 4);
                    int index3 = Rand.rand.Next(0, 4);
                    int flag=Opterator.opthree(num1, num2, num3, num4, index1, index2, index3, Produce.oper);
                    if(flag==1)
                    {
                        i++;
                    }
                }
            }
        }
    }
}
