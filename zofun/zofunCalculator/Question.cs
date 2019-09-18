using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator
{
    public class Question
    {
        
        private string expression;
        private int answer;
        public Question(string expression,int answer)
        {
            this.expression = expression;
            this.answer = answer;
        }
        public int getAnswer()
        {
         
            return answer;
         
        }
        public string getExpression()
        {
            return this.expression;
        }
    }
}
