using System;
using System.Collections.Generic;
using System.Text;

namespace aChao_1
{
    public class SubExpression : SymbelExpression
    {
        public SubExpression(Expression _left, Expression _right) : base(_left, _right)
        {
        }

        public override int interpreter(List<string> equalString)
        {
            return base.left.interpreter(equalString) - base.right.interpreter(equalString);
        }
    }
}
