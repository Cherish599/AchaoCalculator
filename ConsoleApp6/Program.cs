using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Program
    {
         public static void Main(string[] args)
        {
            int n;
            Create create = new Create();
            Console.WriteLine("请输入题目数。。。。。");
            n=Convert.ToInt32(Console.ReadLine());
            Write write = new Write();
            write.write(create.creatti1(n),n);
        }
    }
}
