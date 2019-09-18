using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Threading;

namespace achao
{
    class Program
    {
        public static char[] Operator = { '+', '-', '*', '/' };
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
                Thread.Sleep(200);
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
        public static void Write(string formula)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\软件工程\AchaoCalculator\结果.txt",true);
                sw.WriteLine(formula);
                sw.Close();
            }
            catch
            {
                Console.WriteLine("保存错误！");
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("请输入练习题数量：");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Program.Write(Solve(MakeFormula()));
                Console.WriteLine(Solve(MakeFormula()));
            }
        }
            
        }
    }

