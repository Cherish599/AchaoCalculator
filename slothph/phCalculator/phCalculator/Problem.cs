using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phCalculator;
using System.Threading;

namespace phCalculator
{
    
    public class Problem
    {
        public static string[] fuhao = { "+", "-", "*", "/" };
        //生成题目
        public static void problem()
        {

            Random rad = new Random();
            int yunsuan_num = (int)rad.Next(2, 4);//取2到3的随机数，作为运算符的个数
            int x = 0;
            string timu = null;
            while (x < yunsuan_num)//得到与运算符个数一致的0-100的数字，并放入字符串中
            {
                int num = (int)rad.Next(0, 101);
                string yunsuan = fuhao[(int)rad.Next(0, 4)];
                timu = timu + num.ToString() + yunsuan;
                x++;
            }
            //再取一个随机数作为最后一个被运算的数字
            timu += (int)rad.Next(0, 101);
            //休眠一段，防止随机数一致
            Thread.Sleep(30);
            if (Test.test(timu))//进行测试并计算结果，满足要求的，才会使n减一
                Program.n--;
        }
    }
}
