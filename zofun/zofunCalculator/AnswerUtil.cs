using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator
{
    /// <summary>
    ///利用逆波兰式求解
    /// </summary>
    public static class  AnswerUtil
    {
        //表达式中可能出现的符号
        private static char[] symbol = new char[] { '+', '-', '*', '/', '(', ')' };

        /// <summary>
        /// 将表达式中拆分为数字和运算符
        /// </summary>
        /// <param name="expression">待拆分的表达式</param>
        /// <returns></returns>
        private static List<string> Split(string expression)
        {
            
            List<string> list = new List<string>();
            char[] chars = expression.ToCharArray();
            string value = "";
            foreach(char ch in chars)
            {
                //当前字符是符号
                if (symbol.Contains(ch))
                {
                    if (!"".Equals(value))
                    {
                        //保留之前的结果
                        list.Add(value);
                    }
                    list.Add(ch.ToString());
                    value = "";
                    continue;
                }
                value += ch;
            }
            if (!"".Equals(value))
            {
                list.Add(value);
            }
            return list;


        }

  

        /// <summary>
        /// 判断A的运算优先级是否高于B，是返回true，否则返回false
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        private static bool priority(string A,string B)
        {
            
            if (("*".Equals(A) || "/".Equals(A)) && (!"*".Equals(B) && !"/".Equals(B)))
            {
                return true;
            }
            if (("*".Equals(A) || "/".Equals(A)) && ("*".Equals(B) || "/".Equals(B)))
            {
                return true;
            }

            if (("+".Equals(A) || "-".Equals(A)) && (!"*".Equals(B) && !"/".Equals(B)))
            {
                return true;
            }
            else
            {
                return false;
            }
                
            
        }

        /// <summary>
        /// 将中坠表达式准换为后缀表达式
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private static List<string> PrefixToSuffix(List<string> exp)
        {
            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            foreach(string item in exp)
            {
                if (!symbol.Contains(item.ToCharArray()[0]))
                {
                   //数字直接加入list
                    list.Add(item);
                    continue;
                }
                if (item.Equals("(") || stack.Count==0)
                {
                    stack.Push(item);
                    continue;
                }
                if (item.Equals(")"))
                {
                    while (!stack.Peek().Equals("("))
                    {
                        list.Add(stack.Pop());
                    }
                    stack.Pop();
                    continue;
                }
                while (priority(stack.Peek(), item))
                {
                    list.Add(stack.Pop());
                    if (stack.Count==0)
                        break;
                }
                stack.Push(item);
            }
            while (stack.Count!=0)
            {
                list.Add(stack.Pop());
            }
            return list;
        }

        /// <summary>
        /// 使用逆波兰式的方法计算复杂表达式
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static float calculate(string exp)
        {
      
            List<string> list=PrefixToSuffix(Split(exp));
           
            Stack<string> stack = new Stack<string>();
            foreach(string item in list)
            {
                if (!symbol.Contains(item.ToCharArray()[0]))
                {
                    stack.Push(item);
                    continue;
                }
                else
                {
                    //如果是操作符，则弹出栈顶元素，计算后放入
                    float one = float.Parse(stack.Pop());
                    float two = float.Parse(stack.Pop());
                    float value = 0;
                    if (item.Equals("+"))
                    {
                        value = two + one;
                    }
                    else if (item.Equals("-"))
                    {
                        value = two - one;
                    }
                    else if (item.Equals("*"))
                    {
                        value = two * one;
                    }
                    else if (item.Equals("/"))
                    {
                        if (one == 0)
                        {
                            throw new Exception("除数不能为零");
                        }
                        value = two / one;
                    }
                    stack.Push(value.ToString());
                }
               
            }
            return float.Parse(stack.Pop());
        }
    }
}
