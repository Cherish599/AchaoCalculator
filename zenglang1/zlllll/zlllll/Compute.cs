using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlllll
{
   public  class Compute
    {
        public static char[] str = new char[100];
        private static char[] temp;
        //操作数栈
        Stack<float> num = new Stack<float>();
        //符号栈
        Stack<char> ch = new Stack<char>();
        public Compute(string question)
        {
            temp = question.ToCharArray(); //初始化 
            for (int i = 0; i < str.Length; i++)
            {
                if (i < temp.Length)
                {
                    str[i] = temp[i];
                }
                else
                {
                    str[i] = '\0';
                }
            }
        }
        public int Priority(char s) //权重判断方法
        {
            switch (s)
            {
                case '*':
                    return 2;
                case '/':
                    return 2;
                case '+':
                    return 1;
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }
        public float run()
        {
            int i = 0;
            float tmp = 0, j;
            while (str[i] != '\0' || ch.Count != 0)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    tmp = tmp * 10 + str[i] - '0';
                    i++;
                    if (str[i] < '0' || str[i] > '9')
                    {
                        num.Push(tmp);
                        tmp = 0;
                    }
                }
                else
                {
                    if (ch.Count != 0 && Priority(str[i]) <= Priority(ch.Peek()))
                    {
                        switch (ch.Pop())
                        {
                            case '+':
                                num.Push(num.Pop() + num.Pop());
                                break;
                            case '-':
                                j = num.Pop();
                                num.Push(num.Pop() - j);
                                break;
                            case '*':
                                num.Push(num.Pop() * num.Pop());
                                break;
                            case '/':
                                j = num.Pop();
                                num.Push(num.Pop() / j);
                                break;
                        }
                        continue;
                    }
                    if (str[i] != '\0' && ((num.Count != 0) || (Priority(str[i]) > Priority(ch.Peek()))))
                    {
                        ch.Push(str[i]);
                        i++;
                        continue;
                    }


                }
            }
            return num.Pop();
        }
    }
}
