using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //检测并获取正确的数字
            int number = GetNumber();
            List<string> list = GetPractice(number);
            foreach (string str in list)
            {
                Console.WriteLine(str);
            };
            GetFile(list);
            Console.Read();
                
        }

       public  static int GetNumber()
        {
            Console.WriteLine("请输入你想要生成的练习题数量，并以回车键结束.");
            Console.Write("练习题数量：");
            //练习题输出的数量
            int number;
            try
            {
                //进行输入转换
                number = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("======警告：您输入的数字有误，请重新输入======");
                Console.WriteLine("==============================================");
                number = GetNumber();
            }
            Console.WriteLine("即将打印"+number+"道练习题.......");
            return number;
        }

        public static void GetFile(List<string> list)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter("C:\\Users\\51030\\Desktop\\panghu_rep\\subject.txt", true);
                //将生成的正确的算术式输出到控制台
                foreach (string str in list)
                {
                    streamWriter.WriteLine(str);
                };
                streamWriter.Close();
                Console.WriteLine("打印完成------");
            }
            catch
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("=============错误：文件生成失败===============");
                Console.WriteLine("==============================================");
            }
        }

        public static string GetAnswer(string practice)
        {
            DataTable dateTable = new DataTable();
            // 将算式部分计算出结果并转为字符串
            string answer = dateTable.Compute(practice, null).ToString();
            // 如果结果是个小数，则返回null
            if (double.Parse(answer) % 1 != 0) 
            {
                return null;
            }

            return answer;
        }

        public static List<string> GetPractice(int number)
        {
            //使用List来存储题目
            List<string> list = new List<string>(number) ;
            //运算符，通过生成一个随机数选择数组中的运算符号并映射到字典当中
            string[] optionsArr = new string[] { "+", "-", "*", "/" };
            //小孩子似看不懂计算机里面的乘除的，所以创建一个字典
            Dictionary<string, string> optionsDic = new Dictionary<string, string>();
            optionsDic.Add("+", "+");
            optionsDic.Add("-", "-");
            optionsDic.Add("*", "x");
            optionsDic.Add("/", "÷");

            //生成随机数产生器
            Random random = new Random(Guid.NewGuid().GetHashCode());
            //产生运算符个数 2~3个
            int count = random.Next(2, 4);
            
            for(int i = 1;i <= number; i++)
            {
                //用于拼接计算式
                StringBuilder stringBuilder = new StringBuilder();
                //用于拼接输出式
                StringBuilder stringBuilder2 = new StringBuilder();

                //产生第一个随机数
                int firstNumber = random.Next(1, 41);
                stringBuilder.Append(firstNumber);
                stringBuilder2.Append(firstNumber);
     
                //产生一个练习题
                for (int j = 0; j < count; j++)
                {
                    //产生随机运算符
                    int index = random.Next(0, 4);
                    int randomNumber = random.Next(1, 31);
                    stringBuilder.Append(optionsArr[index]).Append(randomNumber);
                    //添加正确的输出式
                    stringBuilder2.Append(optionsDic[optionsArr[index]]).Append(randomNumber);
                }
                string result = GetAnswer(stringBuilder.ToString());
                //生成不正确的表达式，重新生成
                if (result == null)
                {
                    i--;
                }
                //把正确的结果放在输出的表达式上
                else
                {
                    stringBuilder2.Append(" = "+result);
                    string str = stringBuilder2.ToString();
                    list.Add(str);
                }
            }

            return list;
        }
    }

}
