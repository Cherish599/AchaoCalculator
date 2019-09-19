using System;
using System.Collections.Generic;
using System.Text;

namespace aChao_1
{
     public abstract class SymbelExpression : Expression
    {
        protected Expression left;
        protected Expression right;
        
        public SymbelExpression(Expression _left,Expression _right)
        {
            this.left = _left;
            this.right = _right;
        }
    }
}
