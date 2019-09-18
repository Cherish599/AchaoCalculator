using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Formular
    {
        private int min, max;//操作数范围
        public Formular(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        //表达式
        private string[] expression;
        /// <summary>
        /// 初始化，生成一个数学表达式
        /// </summary>
        /// <param name="min">操作数最小值</param>
        /// <param name="max">操作数最大值</param>
        private void Init(int min, int max)
        {
            int operCount = new Random(Guid.NewGuid().GetHashCode()).Next(2, 4);
            expression = new string[operCount * 2 + 1];
            for (int i = 0; i < expression.Length; i++)
            {
                expression[i] = (i % 2 == 0) ? MyRandom.GetRandomNum(min, max) : MyRandom.GetRandomOpt();
            }
        }

        /// <summary>
        /// 得到多个完整算式，去除负数结果
        /// </summary>
        /// <returns></returns>
        public List<string> GetFullExpressions(int lines)
        {

            List<string> list = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                Init(this.min, this.max);
                string temp = "";
                foreach (var item in this.expression)
                {
                    temp += item;
                }
                string res = GetResult();
                if (int.Parse(res) < 0)
                {
                    i--;
                }
                else
                {
                    list.Add(temp + "=" + GetResult());
                }
            }
            return list;
        }

        /// <summary>
        /// 计算表达式结果
        /// </summary>
        /// <returns></returns>
        private string GetResult()
        {
            Stack<string> vals = new Stack<string>();
            Stack<string> opts = new Stack<string>();

            for(int i = 0; i < expression.Length; i++)
            {
                if ("+-".Contains(expression[i]))
                {
                    opts.Push(expression[i]);
                }
                else if("×÷".Contains(expression[i]))
                {
                    vals.Push(new Executioner(expression[i]).Calc(vals.Pop(), expression[i + 1]));
                    i++;
                }
                else
                {
                    vals.Push(expression[i]);
                }
            }
            //栈内只剩下加减法，为避免连续减法出错，于是将两者逆序便于依次计算
            vals = vals.Count == 0 ? vals : Reverse(vals);
            opts = opts.Count == 0 ? opts : Reverse(opts);

            while (0 != opts.Count)
            {
                vals.Push(new Executioner(opts.Pop()).Calc(vals.Pop(), vals.Pop()));
            }
            return vals.Pop();
        }

        /// <summary>
        /// 反转栈
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private Stack<string> Reverse(Stack<string> param)
        {
            Stack<string> result = new Stack<string>();
            while (param.Count>0)
            {
                result.Push(param.Pop());
            }
            return result;
        }
    }
}
