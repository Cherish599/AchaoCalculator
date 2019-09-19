using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect con = new Connect();
            Calculate cal = new Calculate();
            List<string> resultList = new List<string>();
            Random rd = new Random();
            List<string> list = con.createExpression(3);
            Console.WriteLine("请输入生成题目数量:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                list = con.createExpression(rd.Next(2, 4));
                int result = cal.cal(list);

                if (result > -1)
                {
                    Console.WriteLine(string.Join("", list.ToArray()) + "=" + result.ToString());
                    resultList.Add(string.Join("", list.ToArray()) + "=" + result.ToString());
                    n--;
                }
                if (n == 0)
                {
                    break;
                }

            }
            con.Tofile(resultList);
        }
    }
}
