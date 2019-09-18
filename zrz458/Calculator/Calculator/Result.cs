using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// @author Rongze Zhao
/// @date 2019-09-17 12:00
/// </summary>

/// <summary>
/// 程序关键数据封装类
/// 用于输出和测试
/// </summary>
namespace Calculator
{
    public class Result
    {
        /// <summary>
        /// 前缀表达式字符串
        /// </summary>
        internal StringBuilder infixFormula;
        /// <summary>
        /// 后缀表达式队列
        /// </summary>
        internal Queue<string> formulaQueue;

        /// <summary>
        /// 计算结果
        /// </summary>
        internal int result;

        public Result()
        {
        }

        public Result(StringBuilder stringBuilder, Queue<string> formulaQueue)
        {
            this.infixFormula = stringBuilder;
            this.formulaQueue = formulaQueue;
        }

        public virtual StringBuilder StringBuilder
        {
            get
            {
                return infixFormula;
            }
            set
            {
                this.infixFormula = value;
            }
        }


        public virtual Queue<string> FormulaQueue
        {
            get
            {
                return formulaQueue;
            }
            set
            {
                this.formulaQueue = value;
            }
        }


        public virtual int getResult()
        {
            return result;
        }

        public virtual void setResult(int result)
        {
            this.result = result;
        }

    }
}
