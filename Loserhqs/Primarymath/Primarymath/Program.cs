using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primarymath
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Input.input();
            //Console.WriteLine(n);
            Produce.produce(n);
            Input.sw1.Close();
            Console.ReadKey();
        }
    }
}
