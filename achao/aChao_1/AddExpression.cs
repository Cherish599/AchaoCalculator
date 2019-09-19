using System.Collections.Generic;

namespace aChao_1
{
    public  class AddExpression : SymbelExpression
    {
        public AddExpression(Expression _left, Expression _right) : base(_left, _right)
        {

        }

        public override int interpreter(List<string> equalString)
        {
            return base.left.interpreter(equalString) + base.right.interpreter(equalString);
        }
    }
}
