using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class symbol
    {
        Random rd = new Random();
        public static string[] ch = { "+", "-", "*", "/" };
        public string randSymbol(int num)
        {
            if (num == 1)
                return ch[0];
            else if (num == 2)
                return ch[1];
            else if (num == 3)
                return ch[2];
            else
                return ch[3];
        }
    }
}
