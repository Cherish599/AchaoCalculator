using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        //maker mymaker = new maker();
        static void Main(string[] args)
        {
            maker mymaker = new maker();
            int num = int.Parse(Console.ReadLine());
            mymaker.makequi(num);
            Console.ReadLine();
        }
    }
}
