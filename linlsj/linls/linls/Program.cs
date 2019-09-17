using System;
using System.IO;
using System.Data;

namespace AchaoCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入出题个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, a, b, c, m;
            char[] op = { '+', '-', '*', '/' };
            object end;
            Random rd = new Random();
            DataTable dt = new DataTable();
            while (i < n)
            {
                a = rd.Next(0, 100);
                c = rd.Next(2, 4);
                string str, st;
                str = Convert.ToString(a);

                for (int j = 0; j < c; j++)
                {
                    m = rd.Next(0, 4);
                    b = rd.Next(0, 100);
                    str += op[m] + Convert.ToString(b);
                }
                end = dt.Compute(str, "");
                if (end.ToString().Contains(".") || str.Contains("/0") || int.Parse(end.ToString()) < 0)
                    continue;
                i++;
                st = str.Replace("/", "÷") + "=" + end.ToString();
                Console.WriteLine(st);
                StreamWriter streamWriter = new StreamWriter("test.txt", true);
                streamWriter.WriteLine(st);
                streamWriter.Close();
            }
        }
    }
}
