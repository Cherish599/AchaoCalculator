using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class line3:line
    {

        public override string ToString()
        {
            lstring.Add(num1.ToString());
            lstring.Add(op1.ToString());
            lstring.Add(num2.ToString());
            lstring.Add(op2.ToString());
            lstring.Add(num3.ToString());
            calMulSum(false);
            calMulSum(true);
            calAddSum();

            return num1 + "" + op1 + "" + num2 + "" + op2 + "" + num3 + "=" + sum;
        }

    }
}
