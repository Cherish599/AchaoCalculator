using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int num;
            Console.WriteLine("请输入运算题的数量:");
            num = int.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                var result = Calculate(MakeFormula());
                Console.WriteLine(result);
                string path = @"D:\\subject.txt";
                FileInfo fileInfo = new FileInfo(path);
                StreamWriter sw = fileInfo.AppendText();
                sw.WriteLine(result);
                sw.Flush();
                sw.Close();
            }


            Console.ReadLine();
        }
        //设置随机种子不重复方法
        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        //生成等式左边不加结果的方法
        public static string MakeFormula()
        {
            Random random = new Random(GetRandomSeed());
            string result = null;
            int number = random.Next(0, 101);
            int opCount = random.Next(2, 4);//生成随机字符个数2-3个
                                            //string[] s = { "+", "-", "*", "/" };
                                            //int Operator = random.Next(0, 4);
            result += number;
            for (int i = 0; i < opCount; i++)
            {

                int newNum = random.Next(0, 101);
                int opNumber = random.Next(0, 4);
                result = result + Operator(opNumber) + newNum;

            }
            return result;



        }
        //生成运算符的方法
        public static string Operator(int n)
        {
            if (n == 0)
            {
                return "+";
            }
            else if (n == 1)
            {
                return "-";
            }
            else if (n == 2)
            {
                return "*";
            }
            else
            {
                return "/";
            }
        }
        //生成等式结果的方法
        public static string Calculate(string result)
        {

            DataTable dt = new DataTable();
            object obj = null;
            obj = dt.Compute(result, "");
            while (obj.ToString().Contains(".") || result.Contains
                ("/0") || obj.ToString().Contains("-"))//判断结果是否为小数、运算过程中是否出现除数为0、结果为负数的情况
            {
                result = MakeFormula();
                obj = dt.Compute(result, "");
            }

            return result + "=" + obj.ToString();

        }



    }
}


