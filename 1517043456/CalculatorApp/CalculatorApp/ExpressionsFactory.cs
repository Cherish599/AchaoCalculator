using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// ExpressionFactory：用于获取四则运算式
    /// </summary>
     public class ExpressionsFactory
    {
        
        //随机获取一个运算符
        public string getOperator(int i) {
            String[] OperatorsType = { "+","-","*","/"};
            return OperatorsType[i];
        }
        //返回一个四则运算式
        public string getAnExpression() {
            //用于获取随机数
            //int seeds = 1;
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();
            //运算符个数（2个或3个）
            int operatorNum = (int)rd.Next(2,4);
            //作为数组下标获取运算符
            int operators;
            //数值
            int num;
            int nextNum = rd.Next(0, 100);
            for (int i = 0; i < operatorNum; i++) {
                num = rd.Next(0, 101);
                operators = rd.Next(0,4);
                sb.Append(num).Append(getOperator(operators));
                System.Threading.Thread.Sleep(10);
            }
            sb.Append(nextNum);
            return sb.ToString();
        }
    }
}
