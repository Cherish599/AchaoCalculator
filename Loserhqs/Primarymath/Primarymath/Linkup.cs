using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primarymath
{
    public class Linkup
    {
        //判断算式结果是否为整数
        public static bool nonnegint(double sum)
        {
            if (sum == (int)sum)
                return true;
            else
                return false;
        }
        //两个数的运算
        public static double arith(int a, int b, int s)
        {
            if (s == 0)
                return a + b;
            else if (s == 1)
                return a - b;
            else if (s == 2)
                return a * b;
            else
            {
                if (b != 0)
                {
                    int temp = a / b;
                    if (temp * b == a)
                        return a / b;
                    else
                        return -1;
                }
                else
                    return -1;
            }
        }
    }
}
