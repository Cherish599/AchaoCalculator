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
            int num_1 = int.Parse(Console.ReadLine());//输入的num_1控制题目的个数
            Console.WriteLine("请输入数字运算范围:");
            int num_2 = int.Parse(Console.ReadLine());//输入的num_2限制随机数的范围
            ConstructOperation CO = new ConstructOperation(num_1, num_2);
            CO.Operation();
            Console.WriteLine("是否需要答案?(YES OR NO)");
           string See = Console.ReadLine();
            if (See == "YES")//完整的字符串需要用双引号
            {
                Console.WriteLine("答案如下");//调用看答案的方法，
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
