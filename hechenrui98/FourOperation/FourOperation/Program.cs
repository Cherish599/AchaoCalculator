using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入题目个数：");
            int num_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入数字运算范围:");
            int num_2 = int.Parse(Console.ReadLine());
            ConstructOperation CO = new ConstructOperation(num_1, num_2);
            CO.Operation();
            Console.WriteLine("是否需要答案?(YES OR NO)");
           string See = Console.ReadLine();
            if (See == "YES")
            {
                Console.WriteLine("答案如下");
                CO.LookAnswer();
            }
            else
            {
                Console.WriteLine("感谢您的使用~");
            }
            Console.ReadLine();
        }
    }
}
