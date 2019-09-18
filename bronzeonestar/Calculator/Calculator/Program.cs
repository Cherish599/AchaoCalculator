using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("要出的题的个数：");
            int number= Convert.ToInt32(Console.ReadLine());//输入要出题的个数并赋值给n
            CalculatorMakeup calcuate1 = new CalculatorMakeup(number);
            Console.ReadKey();

        }
    }
}
