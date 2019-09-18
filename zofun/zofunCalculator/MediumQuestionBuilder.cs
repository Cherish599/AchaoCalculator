using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator
{
    /// <summary>
    /// 中等难度四则运算生成器，即包含三个运算符
    /// </summary>
    class MediumQuestionBuilder : Arithmetic
    {
        private Random random = new Random();
        private char[] symbol = new char[4] { '+', '-', '*', '/' };
        public Question MakeQuestion()
        {
            //生成运算符
            char operA = symbol[random.Next(4)];
            char operB = symbol[random.Next(4)];
            char operC = symbol[random.Next(4)];
            int numA;
            int numB;
            int numC;
            int numD;

            string expression;
            float answer;
            //为了避免除法太少，所以出现小数时，不改变运算符，改变运算数
            while (true)
            {
                //生成运算数
                numA = random.Next(100);
                numB = random.Next(100);
                numC = random.Next(100);
                numD = random.Next(100);
                expression = numA.ToString() + operA + numB.ToString() + operB + numC.ToString()+operC+numD.ToString();
                try
                {
                    //捕获表达式中除数为零的异常
                    answer = AnswerUtil.calculate(expression);
                }
                catch
                {
                   
                    //该表达式不合法，重新生成
                    continue;
                }

                //这里限制了结果的最大值不能超过300
                if (answer < 300 && answer >= 0 && !answer.ToString().Contains('.'))
                {
                    break;
                }
            }
            return new Question(expression, (int)answer);

            throw new NotImplementedException();
        }
    }
}
