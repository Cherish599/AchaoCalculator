using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace REOCalculator
{
    public class Program
    {
        public static string[] Op = { "+", "-", "*", "/" };
        public StringBuilder str = new StringBuilder("", 300);
        public string CreateFormula()
        {
            StringBuilder res = new StringBuilder("", 300);
            Random tool = new Random();

            int opnu = tool.Next(2, 3);
            int len = opnu * 2 + 1;
            for (int i = 0; i < opnu + 1; i++)
            {
                res.Append(tool.Next(100).ToString());
                if (i != opnu)
                    res.Append(Op[tool.Next(4)]);
            }
            return res.ToString();
        }
        
        public string calc(string formula)
        {
            string res = "";
            DataTable p = new DataTable();
            res = p.Compute(formula, "").ToString();
            return (res);
        }

        public static void write(string str,string name)
        {
            FileStream FILE = new FileStream(name, FileMode.Append, FileAccess.Write);
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            FILE.Write(data, 0, data.Length);
            string tmp = "\n";
            byte[] data2 = System.Text.Encoding.Default.GetBytes(tmp);
            FILE.Write(data2,0,data2.Length);
            FILE.Flush();
            FILE.Close();
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Program p = new Program();
            int sum = 0;
            string formula = "";
            string res = "";
            string store = "";

            while (sum != n)
            {

                formula = p.CreateFormula();
                System.Threading.Thread.Sleep(10);
                res = p.calc(formula);
                //Console.WriteLine(res);
                if (res.Contains("-") || res.Contains("."))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(formula + " = ");
                    store = formula + " = " + res;
                    write(store, "subject.txt");
                    sum++;
                }

            }

        }
    }
}