using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourOperation
{
    public class ConstructOperation
    {
        int num_1;
        int num_2;
        public double[] result;//创建result数组对答案进行储存
        Random radm = new Random();

        public ConstructOperation(int num_1, int num_2)
        {
            this.num_1 = num_1;
            this.num_2 = num_2;
            result = new double[num_1];
         }

        public char OperationSymbol()
        {
            Random radm = new Random();
            int k = radm.Next(4);
            char[] fu = { '+', '-', '*', '/' };//将四则运算符号放在fu数组里面，
            //Console.WriteLine(fu[k]);
            return fu[k];
        }
        //创建运算符方法
        public void Operation()
        {
            for (int i = 0; i < num_1; i++)
            {
                int a= radm.Next(num_2)+1;//输入的num_2作为随机数的范围限制
                int b= radm.Next(num_2)+1;
                char f = OperationSymbol();
                if (f == '+')
                {
                    Console.WriteLine("{0}:{1}{2}{3}=", i + 1, a, f, b);
                    result[i] = a + b;
                }
                else if (f == '-')
                {
                    if (a > b)
                    {
                        Console.WriteLine("{0}:{1}{2}{3}=", i + 1, a, f, b);
                        result[i] = a - b;
                    }
                    //防止出现差值为负
                    else
                    {
                        Console.WriteLine("{0}:{1}{2}{3}=", i + 1, a, f, b);
                        result[i] = b - a;
                    }
                }
                else if(f=='*')
                {
                    Console.WriteLine("{0}:{1}{2}{3}=", i + 1, a, f, b);
                    result[i] = a * b;
                }
                else
                {
                     Console.WriteLine("{0}:{1}{2}{3}=", i + 1, a, f, b);
                    result[i] = Math.Round(Convert.ToDouble(a) / b, 2);//将有小数的除法的答案都转化为两位小数
                }
            }
        }
        //创建看答案方法
        public void LookAnswer()
        {
            foreach (double i in result)
            {
                Console.WriteLine(i.ToString());

            }
        }
    }
}
