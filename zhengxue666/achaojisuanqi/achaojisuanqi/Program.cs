
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace achaojisuanqi
{
    public class Program
    {


        public static string GreatCalculation()//随机生成等式
        {
            StringBuilder stringBuilder = new StringBuilder();
            string[] sign = { "+", "-", "*", "/" };//符号变量；
            var seed = Guid.NewGuid().GetHashCode();
            //定义一个随机数种子，且不能重复
            Random random = new Random(seed);
            int count;
            count = random.Next(1, 3);
            int start = 0;
            int num = random.Next(0, 101);
            stringBuilder.Append(num);
            while (start <= count)
            {
                int Sign = random.Next(0, 4);//生成运算符
                int num1 = random.Next(0, 101);//生成随机数
                stringBuilder.Append(sign[Sign]).Append(num1);
                start++;
            }
            return stringBuilder.ToString();
        }


        public static string Calculation(string a)//运算
        {
            DataTable dataTable = new DataTable();
            Object obj = dataTable.Compute(a, "");
            while (obj.ToString().Contains(".") || a.Contains("/0") || Convert.ToInt32(obj) < 0)
            {
                a = GreatCalculation();
                obj = dataTable.Compute(a, "");
            }
            return a + "=" + obj.ToString();
        }


        public static void Main(string[] args)//主函数
        {
            Console.WriteLine("请输入打印题目数目：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("结果如下：");
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\郑雪\Desktop\AchaoCalculator\四则运算.txt");
            //将随机生成的等式以记事本的形式写入文件，以便打印
            for (int i = 1; i <= n; i++)
            {
                string a = GreatCalculation();
                string result = Calculation(a);
                Console.WriteLine(result);
                streamWriter.WriteLine(result);
            }
            streamWriter.Close();
        }
    }
}
