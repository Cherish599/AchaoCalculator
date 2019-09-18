using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
   public  class Program
    {
        public static string[] Operation = { "+", "-", "*", "/" };
        //生成表达式
        public static string CreateProblem()
        {
            string result = null;
            var randomseed = Guid.NewGuid().GetHashCode();//生成不相同的式子
            Random random = new Random(randomseed);
            int num = random.Next(0, 101);//生成随机运算数字
            int opern = random.Next(2, 4);//生成随机运算符
            result = num.ToString();
            for(int i=1;i<opern;i++)
            {
                num = random.Next(0, 101);
                int operation = random.Next(0,4);
                result = result + Operation[operation] + num.ToString();
            }
            return result;
        }
        //计算表达式
        public static string Calculate(string result)
        {
            DataTable dt = new DataTable();
            string res = dt.Compute(result, "").ToString();//对运算式进行计算
            while (res.Contains("/0") || res.Contains(".") || Convert.ToInt32(res) < 0)//检查运算结果是否有除数为0，有小数，负数
            {
                result = CreateProblem();
                res = dt.Compute(result, "").ToString();
            }
            return res;
        }
static void Main(string[] args)
        {
                Console.WriteLine("请输入您需要的算术个数：");
                int n = Convert.ToInt32(Console.ReadLine());
                StreamWriter sw = new StreamWriter(@"C:\Users\hp\Desktop\阿超四则运算\AchaoCalculator\subject.txt");
                for (int i = 0; i < n; i++)
                {
                    string result = CreateProblem();//需运算式子的左边部分
                    string res = Calculate(result);//计算式子的结果
                    string final_MathFormula = result + "=" + res;//整个数学等式
                    Console.WriteLine(final_MathFormula);//在屏幕上打印用户想要的n个四则运算式子
                    sw.WriteLine(final_MathFormula);//将运算式子写入TXT文件“subject.txt”中
                }
                sw.Close();//关闭文件
          


        }
    }
}
