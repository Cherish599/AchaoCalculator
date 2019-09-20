using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace homework2
{
    public class Compute
    {
        public static string compute(string formula)
        {
            DataTable dt = new DataTable();
            object result=dt.Compute(formula, null);
            while(result.ToString().Contains('.')|| result.ToString().Contains('-'))
            {
                formula = Equation.creatEquation();
                result = dt.Compute(formula, null);
            }
            return formula+'='+result;
        }
    }
}
