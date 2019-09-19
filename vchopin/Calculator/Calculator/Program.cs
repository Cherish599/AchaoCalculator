using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要多少道题？");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("开始生成题目...");
            string content = "";
            calculate cal = new calculate(n);
            cal.generateNum();
            cal.Lines.ForEach(t =>
            {
                writeToFile(t.ToString());
            });
            Console.WriteLine(content);
            Console.WriteLine("生成完毕");
            Console.ReadKey();
        }
        public static void writeToFile(string str)
        {
            StreamWriter sw = new StreamWriter("subject.txt", true); 

            sw.WriteLine(str);

            sw.Flush();

            sw.Close();
        }

        
    }
}
