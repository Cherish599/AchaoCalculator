using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace  Calculator
{
   public  class CalculatorMakeup
    {
       static  int i = 0;//i为题数
        public CalculatorMakeup(int number)
        {
            char[]F={ '+', '-', '*', '/' };//四个运算符合放入数组中
            Random rd = new Random();
           
            while (i < number)//循环
            {
                int g=rd.Next(5,20);
                int f = rd.Next(2, 4);//随机生成的数字为了进行三个或者四个数字的随机运算,h为运算的符号个数。
                int a = rd.Next(0, 100);//a为随机产生的第一个数的大小
                string result = null;
                result = result + a;
                for (int j = 0; j < f; j++)
                {
                    int m = rd.Next(0, 4);//m为取加减乘除的取值
                    int b = rd.Next(0, 100);//b为随机产生的第二或第三个以及第四个数大小
                    if (F[m] == '/')
                    {
                        if (b != 0)
                            result = result + F[m] + b;
                        else
                          break;
                    }
                    else
                        result = result + F[m] + b;
                }
                if (Answer(result) % 1 == 0 && Answer(result) >= 0)//验证结果是否为小数或负数，结果除以1有余数就说明是小数，为了不为负数必须保证结果大于等于0
                {
                    i++;
                    Console.WriteLine(result + "=" );       
                    StreamWriter questionfile = new StreamWriter("C:/zxm/question.txt", true);
                    questionfile.WriteLine(result);
                    questionfile.Close();
                    StreamWriter answerfile= new StreamWriter("C:/zxm/answer.txt", true);
                    answerfile.WriteLine(Answer(result));
                    answerfile.Close();
                }
             
            }

        }
        public double Answer(string result)//计算运算式的结果
        {

            DataTable da = new DataTable();
            double end = double.Parse(da.Compute(result, "").ToString());
            return end;
        }
        public static  int testc()
        {
            return i;
        }
    }
}
