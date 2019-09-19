using System;
using System.Collections.Generic;
using System.Text;

namespace aChao_1
{
    public class VarExpression : Expression
    {
        public int index;

        public VarExpression(int _index)
        {
            this.index = _index;
        }

        public override int interpreter(List<string> equalString)
        {
            return Convert.ToInt32(equalString[index]);
        }
    }
}
