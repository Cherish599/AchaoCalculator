using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;


namespace Calculator
{
    public class Program
    {
        public static string[] Operation = { "+", "-", "*", "/" };
        public static string Make_Formula()
        {
            string formula = null;
            var seed = Guid.NewGuid().GetHashCode();//用这种方法生成随机数种子使随机生成的式子不相同。
            Random random = new Random(seed);
            int number_1 = random.Next(0, 101);//生成随机运算数字，且取值范围为[0,100]
            int number_2 = random.Next(2, 4);//随机生成运算符个数，且个数范围为[2,4)
            formula = number_1.ToString();
            for (int i = 1; i <= number_2; i++)
            {
                number_1 = random.Next(0, 101);//生成随机运算数字，且取值范围为[0,100]
                int operation = random.Next(0, 4);//随机产生运算符
                formula = formula + Operation[operation] + number_1.ToString();
            }
            return formula;
        }
        public static string Calculate(string formula)
        {
            DataTable dt = new DataTable();
            string result = dt.Compute(formula, "").ToString();//利用DataTable提供方法对随机产生的字符串式子进行运算
            while (formula.Contains("/0") || result.Contains(".") || Convert.ToInt32(result) < 0)//检查运算过程中是否有除0操作、运算结果是否有小数或负数。
            {
                formula = Make_Formula();
                result = dt.Compute(formula, "").ToString();
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("输入你需要的算术个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            StreamWriter sw = new StreamWriter(@"D:\软工作业\AchaoCalculator\jiao54.txt");
            for (int i = 0; i < n; i++)
            {
                string formula = Make_Formula();
                string result = Calculate(formula);
                string final_MathFormula = formula + "=" + result;
                Console.WriteLine(final_MathFormula);
                sw.WriteLine(final_MathFormula);//将运算式子写入txt文件
            }
            sw.Close();
        }
        
    }
}
