using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// 计算结果
    /// 这里使用DataTable的Compute计算结果
    /// </summary>
    public class Solve
    {
        public string GetResult()
        {
            ExpressionsFactory ef = new ExpressionsFactory();
            DataTable dt = new DataTable();
            string expression = ef.getAnExpression();
            //使用compute进行计算
            Object result = dt.Compute(expression,"");
            //如果结果含有小数点，或者表达式中有除以0，或者结果为负数在获取一个计算式
            while (result.ToString().Contains(".") || expression.Contains("/0")
                ||result.ToString().Contains("-")) {
                expression = ef.getAnExpression();
                result = dt.Compute(expression,"");
            }
            //返回一个拼接好的字符串
            return expression+"="+result.ToString();
        }
    }
}
