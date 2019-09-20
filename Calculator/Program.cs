using System;
using System.Data;
using System.IO;
using System.Threading;

namespace AchaoCalculator
{
    class Program
    {
        public static char[] Operator = { '+', '-', '*', '/' }; // 运算符数组
        public static void Main(string[] args)
        {
            int countNumber = 0;
            string finalResult = null;
            Console.Write("请输入要输入出题的道数：");
            countNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < countNumber; i++)
            {
                finalResult += Solve(MakeFormula()) + "\r\n";
                Thread.Sleep(30);                                  //延时，提高随机数不重复概率
            }
            Console.WriteLine(finalResult);
            //保存至本地
            try
            {
                StreamWriter sw = new StreamWriter(@"D:\subject.txt");
                sw.Write(finalResult);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("Error saving text file！");
            }

        }

        //产生运算式

        public static string MakeFormula()
        {
            string result = null;
            Random random = new Random();
            int Number = (int)random.Next(0, 101);
            int op_count = (int)random.Next(2, 4);
            result += Number;
            for (int i = 0; i < random.Next(2, 4); i++)
            {
                Number = (int)random.Next(0, 101);
                op_count = (int)random.Next(0, 4);
                result = result + Operator[op_count] + Number;
            }
            return result;

        }
        //计算运算式
        public static string Solve(string formula)
        {
            DataTable dt = new DataTable();
            object ob = null;
            ob = dt.Compute(formula, "");
            while (ob.ToString().Contains(".") || formula.Contains("/0"))  //判断是否存在小数和除0操作
            {
                formula = MakeFormula();
                ob = dt.Compute(formula, "");
            }

            while (Convert.ToInt32(ob) < 0 || ob.ToString().Contains("."))    //结果出现负数或小数，则重新生成
            {
                formula = MakeFormula();
                ob = dt.Compute(formula, "");
            }
            return formula + "=" + ob.ToString();

        }

    }

}