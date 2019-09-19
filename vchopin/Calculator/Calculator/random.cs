using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class random
    {

        /*
        * Comments : 返回一个符号对应下表
        * Param int m : 最小值
        * Param int n : 最大值
        * Author : vchopin
        * @Return int
        */
        public static int RandomNum(int m=1,int n=101)
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(m, n);
        }

        /*
        * Comments : 返回一个符号对应下表
        * Author : vchopin
        * @Return int
        */
        public static int RandomOp()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmOp = new Random(seed);
            return rdmOp.Next(0, 4);
        }
        /*
        * Comments : 返回0或1
        * Author : vchopin
        * @Return int
        */
        public static int Random3or4()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(0,2);
        }
        /*
        * Comments : 返回一个能够除的
        * Author : vchopin
        * @Return int
        */
        public static int RandomDiv(int n)
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(1, n/2+1);
        }

    }
}
