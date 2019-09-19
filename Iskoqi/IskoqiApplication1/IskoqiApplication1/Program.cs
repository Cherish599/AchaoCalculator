using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IskoqiApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char yn='d';
            
            Console.WriteLine("输入题数：");
            int m= int.Parse (Console.ReadLine());
            Console.WriteLine("是否要结果y or n：");
            yn = char.Parse( Console.ReadLine());
            Iskoqi rad = new Iskoqi(yn);
            rad.size(m);
            Console.ReadLine();
        }
    }
}
