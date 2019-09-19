using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.IO;
using phCalculator;


namespace phCalculator
{
    public class Program
    {
        
        public static List<string> ans = new List<string>();
        public static int n;
        public static void Main(string[] args)
        {
            Console.Write("请输入生成题目个数： ");
           n =Convert.ToInt32(Console.ReadLine());
            //备份要求的题目个数
            int num = n;
            while (n>0)
            {
                Problem.problem();  
            }
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(ans[i]);
            }
            WriteFile.writeFile(num);
        }
    }
}
