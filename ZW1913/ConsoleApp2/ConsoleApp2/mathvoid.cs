using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _Random
{
    public class mathvoid
    {
        public static int right = 0;                          //记录答对的总数！
        public static int wrong = 0;                          //记录答错的总数！


        public void mathjian()                                //减法运算！
        {
            int result;
            int a, b, c;
            Random rd = new Random();
            a = rd.Next(0, 101);
            b = rd.Next(0, 101);
            c = rd.Next(0, 101);
            Console.WriteLine("请计算：{0}-{1}-{2}=？", a, b, c);
            result = Convert.ToInt32(Console.ReadLine());
            if (result == a - b - c)
            {
                Console.WriteLine("回答正确！");
                right++;
            }
            else
            {
                Console.WriteLine("错误，正确的答案是" + (a - b - c));
                wrong++;
            }
        }
        public void mathjia()                                 //加法运算！
        {
            int a, b, c;
            int result;
            Random rd = new Random();
            a = rd.Next(0, 101);
            b = rd.Next(0, 101);
            c = rd.Next(0, 101);
            Console.WriteLine("请计算：{0}+{1}+{2}=？", a, b, c);
            result = Convert.ToInt32(Console.ReadLine());
            if (result == a + b + c)
            {
                Console.WriteLine("回答正确！");
                right++;
            }
            else
            {
                Console.WriteLine("错误，正确的答案是" + (a + b + c));
                wrong++;
            }

        }
        public void mathcheng()                               //乘法运算！
        {
            int a, b,c;
            int result;
            Random rd = new Random();
            a = rd.Next(0, 101);
            b = rd.Next(0, 101);
            c = rd.Next(0, 101);
            Console.WriteLine("请计算：{0}*{1}*{2}=？", a, b,c);
            result = Convert.ToInt32(Console.ReadLine());
            if (result == a * b * c)
            {
                Console.WriteLine("回答正确！");
                right++;
            }
            else
            {
                Console.WriteLine("错误，正确的答案是" + (a * b * c));
                wrong++;
            }


        }
        public void mathchu()                                 //除法运算！
        {
            int a, b,c;
            int result;
            Random rd = new Random();
            a = rd.Next(0, 1000);
            b = chooseRandomFactor(a);
            c = chooseRandomFactor(b);
            if (b != 0 && c !=0)
            {
                Console.WriteLine("请计算：{0}/{1}/{2}=？", a, b,c);
                result = Convert.ToInt32(Console.ReadLine());
                if (result == a / b)
                {
                    Console.WriteLine("回答正确！");
                    right++;
                }
                else
                {
                    Console.WriteLine("错误，正确的答案是" + (a / b /c));
                    wrong++;
                }

            }
        }

        private static int chooseRandomFactor(int num)
        {
            int[] arr = new int[num + 1];
            int size = 0;
            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    arr[size++] = i;
                    arr[size++] = num / i;
                }
            }
            int r = new Random().Next(size);
            return arr[r];
        }
    }
}