using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
namespace achao
{


    public class Calculator
    {
        public static string[] sym = new string[] { "+", "-", "*", "/" };
        public static void output(int n)
        {
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\MAC1\Desktop\各种乱七八糟的作业\subject.txt", true);
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string question = createqu();
                string answer = verify(question);
                if (answer == null) // 如果是个小数，则continue
                {
                    i--; continue;
                }
                list.Add(question + "=" + answer);
                Console.WriteLine(question + "=" + answer);

            }

            foreach (string s in list)
            {
                streamWriter.WriteLine(s);
            }
            Console.ReadLine();
        }
        public static string createqu()
        {
            StringBuilder build = new StringBuilder();
            Random ranum = new Random(Guid.NewGuid().GetHashCode());    //产生随机数     
            int sym_num = ranum.Next(1, 4);
            int start = 0;
            int num1 = ranum.Next(1, 101);
            build.Append(num1);
            for (start = 0; start <= sym_num; start++)
            {
                int idx = ranum.Next(0, 4);      // 随机运算符
                int num2 = ranum.Next(1, 101);
                build.Append(sym[idx]).Append(num2);         // 连接数字与字符
                start++;
            }
            return build.ToString();
        }
        public static string verify(string question)     //计算算式结果，并筛选结果为整数的式子
        {
            DataTable dt = new DataTable();
            string answer = dt.Compute(question, null).ToString();         // 将算式部分计算出结果并转为字符串
            if (double.Parse(answer) % 1 != 0 || double.Parse(answer) < 0)         // 如果结果是个小数，则返回null
            {
                return null;
            }

            return answer;
        }

        public static void Main(string[] args)
        {
            Console.Write("请输入算式个数：");
            int n = int.Parse(Console.ReadLine());
            output(n);
        }
    }

}
