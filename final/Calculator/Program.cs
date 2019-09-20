using System;
using System.Data;
using System.IO;
using System.Text;


namespace Calculator
{
    class Program
    {
        public string Formula()
        {
            Random ran = new Random();
            char[] operation = { '+', '-', '*', '/' };
            string formula = Convert.ToString(ran.Next(0, 100));
            int count = ran.Next(2, 4);
            for (int i = 0; i < count; i++)
            {
                int symbol = ran.Next(0, 4);
                int number = ran.Next(1, 100);
                formula += operation[symbol] + Convert.ToString(number);
            }
            return formula;
        }
        public string Solve(string forml)
        {
            object result = null;
            DataTable dt = new DataTable();
            result = dt.Compute(forml, "");
            while (result.ToString().Contains('.') || result.ToString().Contains('-'))
            {
                forml = Formula();
                result = dt.Compute(forml, "");
            }
            return forml + "=" + result.ToString();
            
        }
        /*public static void Write(string res)
        {
            StreamWriter writer = new StreamWriter("D:\\program\final\ti.txt", true, System.Text.Encoding.Default);
            writer.Write(res);
            writer.Close();
        }*/
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("how many questions you want:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string forml = p.Formula();
                string res = p.Solve(forml);
           //     Write(res);
                Console.WriteLine(res);
                
            }

        }
    }
}
