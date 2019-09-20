using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*程序接收一个命令行参数 n，然后随机产生 n 道加减乘除（分别使用符号+-* /来表示）练习题，每个数字在 0 和 100 之间，运算符在 2 个 到 3 个之间。
由于阿超的孩子才上一年级，并不知道分数。所以软件所出的练习题在运算过程中不得出现非整数，比如不能出现 3÷5+2=2.6 这样的算式。
练习题生成好后，将生成的 n 道练习题及其对应的正确答案输出到一个文件 subject.txt 中。
当程序接收的参数为4时，以下为一个输出文件示例。

13+17-1=29
11*15-5=160
3+10+4-16=1
15÷5+3-2=4
*/
namespace Calculator
{
    public static class Program
    {
        //随机生成数字
        public static int RandomN(int n)
        {
            Thread.Sleep(100);
            Random random = new Random();
            return random.Next(n);
        }
        //随机生成符号
        public static string Op()
        {
            Thread.Sleep(100);
            Random random = new Random();
            int a = random.Next(4) + 1;
            switch(a)
            {
                case 1:
                    return "+";
                case 2:
                    return "-";
                case 3:
                    return "*";
                case 4:
                    return "/";
            }
            return "0";
        }
        //形成算式
        public static string Formula()
        {
            string formula;
            int Operator = RandomN(2) + 2;
            formula = Convert.ToString(RandomN(100));
            for (int j = 1; j < Operator + 1; j++)
            {
                formula = formula + Op() + Convert.ToString(RandomN(100));
            }
            return formula;
        }
        //计算表达式的值
        public static double CalcByDataTable(string expression)
        {
            DataTable table = new DataTable();
            string value = table.Compute(expression, "").ToString();
            return Convert.ToDouble(value);
        }
        //写入文件
        public static void WriteTxtToFile(string Strs)
        {
            if (string.IsNullOrEmpty(Strs))
                return;
            if (Directory.Exists("D:subject.txt"))  //如果不存在就创建file文件夹
            {
                Directory.CreateDirectory("D:subject.txt");
            }
            StreamWriter sw = new StreamWriter("D:subject.txt", true, System.Text.Encoding.Default);
            sw.WriteLine(Strs);   //写入字符串
            sw.Close();
        }
        //判断条件
        public static int Judge(double result)
        {
            if (result<=500&&result>=0&&(result%1)==0)
            {
                return 1;
            }
            else return 0;
        }
        //主函数
        static void Main(string[] args)
        {
            int n;
            Console.Write("请输入你想要得到的算式的数目：");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=0;i<n;)
            {
                string formula = Formula();
                if (Judge(CalcByDataTable(formula)) == 1)
                {
                    string final;
                    final = formula + "=" + CalcByDataTable(formula);
                    Console.WriteLine(final);
                    WriteTxtToFile(final);
                    i++;
                }
                
            }

        }
    }
}
