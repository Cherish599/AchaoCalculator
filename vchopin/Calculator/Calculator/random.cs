using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class random
    {

        public static int RandomNum(int m=1,int n=101)
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(m, n);
        }

        public static int RandomOp()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmOp = new Random(seed);
            return rdmOp.Next(0, 4);
        }
        public static int Random3or4()
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(0,2);
        }
        public static int RandomDiv(int n)
        {
            var seed = Guid.NewGuid().GetHashCode();
            Random rdmNum = new Random(seed);
            return rdmNum.Next(1, n/2+1);
        }

    }
}
