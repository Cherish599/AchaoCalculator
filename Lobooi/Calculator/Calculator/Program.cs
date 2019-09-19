using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//xiaowu 简单四则运算

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入题目个数：");
            int num_g = int.Parse(Console.ReadLine());//确定题目个数

            Console.WriteLine("请输入运算数字范围：");
            int num_f = int.Parse(Console.ReadLine());//运算范围

            SiZeYuanSuan YS = new SiZeYuanSuan(num_g, num_f);
            YS.YunSuanSC();

            Console.WriteLine("是否查看答案（YorN）：");
            char See = char.Parse(Console.ReadLine());
            if (See == 'Y' || See == 'y')
            {
                Console.WriteLine("答案如下");
                YS.SeeResult();
            }
            else
            { 
                Console.WriteLine("感谢使用！");
            }
            string str = Console.ReadLine();
        }
    }
}
