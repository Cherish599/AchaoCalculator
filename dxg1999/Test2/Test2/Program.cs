using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Test2
{
    public class Program
    {
        public static string[] Operation_Symbol = { "+", "-", "*", "/" };
        static void Main(string[] args)
        {

                Console.Write("请你输入要生成算式的个数：");
                int x = Convert.ToInt32(Console.ReadLine());
                StreamWriter writer = new StreamWriter(@"F:\练习\Calculator\subject.txt");
                for (int i = 0; i < x; i++)
                {
                    string formula = Create();
                    string result = Calculate(formula);
                    string final_result = formula + "=" + result;//算式整合
                    Console.WriteLine(final_result);
                    writer.WriteLine(final_result);
                }
                writer.Close();//关闭
        }
            public static string Create()
            {
                string formula = null;
                var seed = Guid.NewGuid().GetHashCode();//C#中默认以时间作为随机数种子，那么随机生成的运算式子很多都是相同的（伪随机）。但用这种方法生成随机数种子使随机生成的式子不相同。
                Random random = new Random(seed);
                int number = random.Next(0, 100);//生成随机运算数字，且取值范围为[0,100]
                int Symbol = random.Next(2, 4);//随机生成运算符个数，且个数范围为[2,4)
                formula = number.ToString();
                for (int i = 0; i < Symbol; i++)
                {
                    number = random.Next(0, 101);//生成随机运算数字，且取值范围为[0,100]
                    int operation = random.Next(0, 4);//随机产生运算符
                    formula = formula + Operation_Symbol[operation] + number.ToString();
                }
                return formula;
            }
            //计算算式
            public static string Calculate(string formula)
            {
                DataTable dt = new DataTable();
                string result = dt.Compute(formula, "").ToString();//利用DataTable提供方法对随机产生的字符串式子进行运算
                if (formula.Contains("/0") || result.Contains(".") || Convert.ToInt32(result) < 0)//检查运算过程中是否有除0操作、运算结果是否有小数或负数。
                {
                    formula = Create();
                    result = dt.Compute(formula, "").ToString();
                }
                return result;
            }

    }


}