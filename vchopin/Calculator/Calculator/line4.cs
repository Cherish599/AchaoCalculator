using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class line4:line
    {
        public override string ToString()
        {
            lstring.Add(num1.ToString());
            lstring.Add(op1.ToString());
            lstring.Add(num2.ToString());
            lstring.Add(op2.ToString());
            lstring.Add(num3.ToString());
            lstring.Add(op3.ToString());
            lstring.Add(num4.ToString());

            calMulSum(false);
            calMulSum(true);
            calAddSum();

            return num1 + "" + op1 + "" + num2 + "" + op2 + "" + num3 + "" + op3 + "" + num4 + "=" + sum;
        }
        
    }
}
