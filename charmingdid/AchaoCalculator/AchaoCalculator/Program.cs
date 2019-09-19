using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;


namespace AchaoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*quesNum指定练习题的数量,由键盘输入，
            signNum指定运算符的个数，由随机数生成*/
            int quesNum, signNum;

            //sign保存有加减乘除四个运算符
            char[] sign = { '+', '-', '*', '/' };

            //fomula保存包含数字和运算符在内的计算式
            string fomula = null;

            /*创建三个随机数对象分别用于随机运算符个数、
             每道练习题的计算数字、每道练习题使用的运算符，
             通过让程序睡眠改变随机种子*/
            Random rd1 = new Random();
            Thread.Sleep(1);
            Random rd2 = new Random();
            Thread.Sleep(1);
            Random rd3 = new Random();

            //创建数据表用于计算练习题的结果
            DataTable dt = new DataTable();

            //从键盘接收一个整数赋值给quesNum
            Console.WriteLine("输入计算题的数量：");
            quesNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quesNum; i++)
            {
                /*调用rd1的Next方法生成随机数并赋值给signNum，
                signNum为奇数则运算符个数为3，否则为2*/
                signNum = rd1.Next();
                if (signNum % 2 == 1)
                {
                    signNum = 3;
                }
                else
                {
                    signNum = 2;                                                                                                                                                                    
                }

                /*onum用于保存每道练习题的signNum+1个数字，
                 通过循环调用rd2的Next方法生成0-100的随机数并赋值给onum中每一个数*/
                int[] onum = new int[signNum + 1];
                for (int j = 0; j <= signNum; j++)
                {
                    onum[j] = rd2.Next(0, 101);
                }

                /*osign用于保存每道练习题的signNum个运算符，
                 通过循环调用rd3的Next方法生成0-3的随机数并与sign匹配确定运算符*/
                char[] osign = new char[signNum];
                for (int j = 0; j < signNum; j++)
                {
                    int l = rd3.Next() % 4;
                    osign[j] = sign[l];
                }
                
                //将随机生成的数字和运算符结合成计算题并存入fomula
                for (int j = 0; j <= signNum; j++)
                {
                    if (j > 0)
                    {
                        fomula += osign[j - 1];
                    }
                    fomula += onum[j];
                }

                //剔除被除数为0、结果为负数或小数的练习题
                for (int j = 0; j < signNum; j++)
                {
                    if ((fomula[j * 2] == '/') && (fomula[j * 2 + 1] == '0'))
                    {
                        fomula = null;
                        i--;
                    }
                }
                if (fomula != null)
                {
                    if ((dt.Compute(fomula, null).ToString())[0] == '-')
                    {
                        fomula = null;
                        i--;
                    }
                    else if ((dt.Compute(fomula, null).ToString()).Contains('.'))
                    {
                        fomula = null;
                        i--;
                    }
                }

                /*将练习题的计算式和答案都输出至指定路径的txt文件中，
                 清除当先保存在fomula中的计算式*/
                if (fomula != null)
                {
                    string a = fomula + '=' + (dt.Compute(fomula, null).ToString());
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\fomula.txt", true))
                    {
                        file.WriteLine(a);

                    }
                }
                fomula = null;
            }
            Console.WriteLine("练习题输出完成！");
            Console.Read();
        }
    }
}
