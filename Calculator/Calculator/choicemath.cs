using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class choicemath
    {
        public int Option(int x,string symbol,int y)
        {
            if (symbol == "+")
                return x + y;
            else if (symbol == "-")
                return x - y;
            else if (symbol == "*")
                return x * y;
            else
                return x / y;
        }
    }
}
