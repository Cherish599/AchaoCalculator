using System;
namespace cee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入出题个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintCalcuate calcuate1 = new PrintCalcuate(n);
            Console.ReadKey();

        }
    }
}
