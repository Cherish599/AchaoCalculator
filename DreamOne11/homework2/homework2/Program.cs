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
                
                Thread.Sleep(100);
            }
        }
    }
}


//问题一：类之间的调用问题 
//问题二：生成不重复随机数
//问题三：如何用string变量保存等式
//问题四：如何避免一个等式中频繁出现除号
//问题五：如何计算string 变量中所保存的等式
//问题六：等式中出现一个运算符或没有运算符
//问题七：文件写入时只记录了最后一个等式