using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Primarymath
{
    public class Input
    {
        public static int input()
        {
            Console.WriteLine("请输入需要产生的题目数：");
            //题目数量
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        //文本输出
        public static StreamWriter sw1 = new StreamWriter(@"E:\gitKU\AchaoCalculator\Loserhqs\Primarymath\Primarymath\result.txt");
    }
}
