using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Solve
    {
        public static string Solve(string formula)
        {
            DataTable dt = new DataTable();
            object result = dt.Compute(formula, null);
            while (result.ToString().Contains('.') || result.ToString().Contains('-'))
            {
                dengshi = Program.Formula();
                result = dt.Compute(formula, null);
            }
            return formula + '=' + result;
        }
    }
}
