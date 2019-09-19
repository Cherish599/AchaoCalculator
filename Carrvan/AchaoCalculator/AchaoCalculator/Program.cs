using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace AchaoCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //获取题目个数n
            Console.WriteLine("请输入题目个数:");
            int n = int.Parse(Console.ReadLine());
            //int n = 300000;
            //题目字符数组
            ArrayList questions = new ArrayList();
            //调用出题函数SetQuestion
            questions = SetQueation(n, questions);
            //调用写入到txt文件函数ToTxt
            ToTxt(questions);
            
            Console.ReadKey();
        }
        //出题函数SetQuestion
        public static ArrayList SetQueation(int n, ArrayList questions)
        {
            Random random = new Random();
            //出n道题
            for (int i = 0; i < n; i++)
            {
                
                //结果
                int result;
                
                //第i+1道题有o个运算符
                int o= random.Next(2, 4);
                string[] sign = new string[] { "+", "-", "*", "÷" };
                int[] a = new int[o+1];
                int[] count = new int[o+1];
                for (int j = 0; j < o+1; j++)
                {
                    //o+1个运算数
                    a[j]= random.Next(0, 100);
                    count[j] = a[j];
                }
                //一道题,以a[0]为开头
                string equation = Convert.ToString(a[0]);
                int[] b = new int[o];
                for (int j = 0; j < o ; j++)
                {
                    //o个运算符
                    b[j] = random.Next(1, 5);
                }
                //调整算式
                for (int j = 0; j < o; j++)
                {
                    if (b[j] == 4)
                    {
                        count[j + 1] = random.Next(1, 100);
                        while (count[j] % count[j + 1] != 0)
                        {
                            count[j + 1] = random.Next(1, 100);
                        }
                        a[j + 1] = count[j + 1];
                        count[j] = count[j] / count[j + 1];
                        count[j + 1] = 1;
                    }
                    if (j > 0 && b[j] == 3 && b[j - 1] == 4) 
                    {
                        
                    }
                    if (b[j] == 3 && j == 0)  
                    {
                        count[j] = count[j] * count[j + 1];
                        count[j + 1] = 1; 
                    }
                    if (j > 0 && b[j] == 3 && b[j - 1] != 4)
                    {
                        count[j] = count[j] * count[j + 1];
                        count[j + 1] = 1;
                    }

                }

                //调用计算结果函数CountResult
                result = CountResult(count,b,o);
                //生成第i道题
                for (int j = 0; j < o ; j++)
                {
                    if (j == o - 1)
                    equation = equation + sign[b[j]-1] + a[j + 1]+"="+result;
                    else 
                    equation = equation + sign[b[j]-1] + a[j + 1];
                }
                //输出
                Console.WriteLine(equation);
                questions.Add(equation);
            }
            return questions;
        }
        //计算结果函数CountResult
        public static int CountResult(int[] count,int [] b,int o)
        {
            int result;
            result = count[0];
            for (int j = 0; j < o; j++)
            {
                if (b[j] == 1)
                {
                    result = result + count[j + 1];
                }
                if (b[j] == 2)
                {
                    result = result - count[j + 1];
                }
                if (b[j] == 3)
                {
                    result = result * count[j + 1];
                }
                if (b[j] == 4)
                {
                    result = result / count[j + 1];
                }
            }
            return result;
        }

        //写入到txt文件函数ToTxt
        public static void ToTxt(ArrayList questions)
        {
            // 创建文件。如果文件存在则覆盖
            FileStream fs = File.Open(@"D:\\AchaoCalculator\\Carrvan\\AchaoCalculator\\AchaoCalculator\\bin\\Debug\\subject.txt", FileMode.Create);
            // 创建写入流
            StreamWriter wr = new StreamWriter(fs);
            // 将ArrayList中的每个项逐一写入文件
            for (int i = 0; i < questions.Count; i++)
            {
                wr.WriteLine(questions[i]);
            }
            // 关闭写入流
            wr.Flush();
            wr.Close();

            // 关闭文件
            fs.Close();
        }
    }
}
