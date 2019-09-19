using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    public class Calculate
    {
        //创建栈，用来计算
        private Stack<string> stack = new Stack<string>();

        private int calStack()
        {
            //判断生成的算式是否合格，不合格返回-1
            if (stack.Contains("false"))
            {
                stack.Clear();
                return -1;
            }
            else
            {
                //计算
                while (true)
                {
                    //如果栈中只有一个元素，直接返回这个元素
                    if (stack.Count() <= 1)
                    {
                        return Convert.ToInt32(stack.Pop());
                    }
                    //取出栈顶
                    int top = Convert.ToInt32(stack.Pop());
                    int bottom = 0;
                    //取出运算符
                    switch (stack.Pop())
                    {
                        case "+":
                            bottom = Convert.ToInt32(stack.Pop());
                            stack.Push((top + bottom).ToString());
                            break;
                        case "-":
                            bottom = Convert.ToInt32(stack.Pop());
                            stack.Push((top - bottom).ToString());
                            break;
                    }
                }
            }
        }

        //乘和除的运算优先级比加减高
        public int cal(List<string> list)
        {
            //倒序入栈，则出栈的时候就是顺序的
            for (int i = list.Count() - 1; i >= 0; i--)
            {
                //判断运算符
                if (list[i] == "*")
                {

                    string top = stack.Pop();
                    string bottom = list[i - 1];
                    stack.Push((Convert.ToInt32(top) * Convert.ToInt32(bottom)).ToString());
                    i -= 1;
                }
                else if (list[i] == "/")
                {
                    string bottom = stack.Pop();
                    string top = list[i - 1];
                    int result_div = Convert.ToInt32(top) / Convert.ToInt32(bottom);
                    //判断算式的合格性，如果有小数，直接入栈false，证明此等式不合格
                    if (result_div * Convert.ToInt32(bottom) != Convert.ToInt32(top))
                    {
                        stack.Push("false");
                        break;
                    }
                    stack.Push(result_div.ToString());
                    i -= 1;
                }
                else
                {
                    stack.Push(list[i]);
                }
            }
            //调用加减栈计算 
            return this.calStack();
        }
    }
}
