using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要生成的习题个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            string finallResult;
           for (int i = 0; i < n; i++)
            {
                finallResult = Equation.creatEquation();
                WriteToFile.save(Compute.compute(finallResult));
                Console.WriteLine(Compute.compute(finallResult));
                Thread.Sleep(10);
            }
        }
    }
}

