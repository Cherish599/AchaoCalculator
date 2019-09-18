using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator
{
    class Context
    {
        private Arithmetic arithmetic;
        public Context(Arithmetic arithmetic)
        {
            this.arithmetic = arithmetic;
        }

        public Question buildQuestion()
        {
            return this.arithmetic.MakeQuestion();
        }
    }
}
