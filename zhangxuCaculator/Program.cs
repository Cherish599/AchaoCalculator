using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace zhangxu_Caculator
{
    public class Caculator
    {
        public static char[] symbol = { '+', '-', '*', '/' };
        public static string Profunc()
        {
            String func = null;
            Random numsyb = new Random(Guid.NewGuid().GetHashCode());
            int num = numsyb.Next(1, 101);
            int j, i, s, k;
            func = func + num;
            j = numsyb.Next(1, 3);
            for (i = 0; i <= j; i++)
            {
                k = numsyb.Next(1, 101);
                s = numsyb.Next(0, 4);
                func = func + symbol[s] + k;
            }
            return func;
        }

        public static string Compute(string func)
        {
            string aws = null;
            DataTable m = new DataTable();
            aws = m.Compute(func, null).ToString();
            if (double.Parse(aws) % 1 != 0)
            {
                return null;
            }
            return aws;
        }

        public static void Xuwrite(string aws)
        {


            StreamWriter sw = new StreamWriter("C:\\Users\\MagicBook\\Desktop\\xu.txt", true, System.Text.Encoding.Default);
            sw.WriteLine(aws);
            sw.Close();
        }


        static void Main(string[] args)
        {
            int n;
            string m = null;
            Console.Write("输入个数：");
            n = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < n)
            {
                string func = Profunc();
                string aws = Compute(func);
                i++;
                if (aws == null)
                {
                    i--;
                    continue;
                }
                Console.WriteLine(func + "=" + aws);
                m = func + "=" + aws;
                Xuwrite(m);
            }
            Console.ReadLine();
        }
    }
}


