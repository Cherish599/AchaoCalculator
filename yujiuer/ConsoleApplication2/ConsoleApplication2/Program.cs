using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Program
    {
        public static string[] Operation = { "+", "-", "*", "/" };

        public static string Formula()
        {
            string formula = null;
            var seed = Guid.NewGuid().GetHashCode();
            Random random = new Random(seed);
            int number_1 = random.Next(0, 101);
            int number_2 = random.Next(2, 4);
            formula = number_1.ToString();
            for (int i = 1; i <= number_2; i++)
            {
                number_1 = random.Next(0, 101);
                int operation = random.Next(0, 4);
                formula = formula + Operation[operation] + number_1.ToString();
            }
            return formula;
        }

        public static string Calculate(string formula)
        {
            DataTable dt = new DataTable();
            string result = dt.Compute(formula, "").ToString();
            while (formula.Contains("/0") || result.Contains(".") || Convert.ToInt32(result) < 0)
            {
                formula = Formula();
                result = dt.Compute(formula, "").ToString();
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("请输入题目个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            StreamWriter sw = new StreamWriter(@"C:\软工作业\AchaoCalculator\subject.txt");
            for (int i = 0; i < n; i++)
            {
                string formula = Formula();
                string result = Calculate(formula);
                string final_MathFormula = formula + "=" + result;
                Console.WriteLine(final_MathFormula);
                sw.WriteLine(final_MathFormula);
            }
            sw.Close();
            Console.ReadLine();
        }
    }
}
