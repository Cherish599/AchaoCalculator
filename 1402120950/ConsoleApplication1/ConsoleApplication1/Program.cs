using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {public static class ExpresstionClass
        {
            public static string Expresstion;//String类型表达式

            /// <summary>
            /// 判断字符串是否为数值
            /// </summary>
            /// <param name="str">string</param>
            /// <returns></returns>
            public static bool IsNumberExp(string str)
            {
                bool isnumeric = false;
                byte c;
                if (str == null || str.Length == 0)
                    return false;
                System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
                byte[] bytestr = ascii.GetBytes(str);
                for (int i = 0; i < bytestr.Length; i++)
                {
                    c = bytestr[i];
                    if ((c >= 48 && c <= 57) || c == 46)
                    {
                        isnumeric = true; ;
                    }
                    else
                    {
                        if (c == 45 && bytestr.Length > 1)
                        {
                            isnumeric = true;
                        }
                        else
                        {
                            isnumeric = false;
                            break;
                        }
                    }
                }
                return isnumeric;
            }

            // 基本一目计算
            public static double account(double n1, double n2, string num_op)
            {
                double aresult = 0;
                switch (num_op)
                {
                    case "+":
                        aresult = n1 + n2;
                        break;
                    case "-":
                        aresult = n1 - n2;
                        break;
                    case "*":
                        aresult = n1 * n2;
                        break;
                    case "/":
                        aresult = n1 / n2;
                        break;
                }
                return aresult;
            }

            /// <summary>
            /// 将String类型表达式转为由操作数和运算符组成的ArrayList类型表达式
            /// </summary>
            /// <param name="exp_str">string</param>
            /// <returns></returns>
            public static ArrayList Toexp_arraylist(string exp_str)
            {
                string exp_element = "", expchar;
                ArrayList exp_arraylist = new ArrayList();
                //遍历表达式
                for (int i = 0; i < exp_str.Length; i++)
                {
                    expchar = exp_str.Substring(i, 1);
                    //如果该字符为数字,小数字或者负号(非运算符的减号）
                    if (char.IsNumber(exp_str, i) || expchar == "." || (expchar == "-" && (i == 0 || exp_str.Substring(i - 1, 1) == "(")))
                    {
                        exp_element += expchar;//存为操作数
                    }
                    else//为运算符
                    {
                        //将操作数添加到ArrayList类型表达式
                        if (exp_element != "")
                            exp_arraylist.Add(exp_element);
                        //将运算符添加到ArrayList类型表达式
                        exp_arraylist.Add(expchar);
                        exp_element = "";
                    }
                }
                //如果还有操作数未添加到ArrayList类型表达式,则执行添加操作
                if (exp_element != "")
                    exp_arraylist.Add(exp_element);
                return exp_arraylist;
            }

            //返回运算符的优先级
            private static int Operatororder(string op)
            {
                switch (op)
                {
                    case "*":
                        return 3;
                        break;
                    case "/":
                        return 4;
                        break;
                    case "+":
                        return 1;
                        break;
                    case "-":
                        return 2;
                        break;
                    default:
                        return 0;
                        break;
                }
            }
            private static bool IsPop(string op, Stack operators)
            {
                if (operators.Count == 0)
                {
                    return false;
                }
                else
                {
                    if (operators.Peek().ToString() == "(" || Operatororder(op) > Operatororder(operators.Peek().ToString()))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

            /// <summary>
            /// 将ArrayList类型的中缀表达式转为ArrayList类型的后缀表达式
            /// </summary>
            /// <param name="exp">ArrayList</param>
            /// <returns></returns>
            public static ArrayList Toexpback_arraylist(ArrayList exp)
            {
                ArrayList expback_arraylist = new ArrayList();
                Stack operators = new Stack();
                string op;
                //遍历ArrayList类型的中缀表达式
                foreach (string s in exp)
                {
                    //若为数字则添加到ArrayList类型的后缀表达式
                    if (IsNumberExp(s))
                    {
                        expback_arraylist.Add(s);
                    }
                    else
                    {
                        switch (s)
                        {
                            //为运算符
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                                while (IsPop(s, operators))
                                {
                                    expback_arraylist.Add(operators.Pop().ToString());
                                }
                                operators.Push(s);
                                break;
                            //为开括号
                            case "(":
                                operators.Push(s);
                                break;
                            //为闭括号
                            case ")":
                                while (operators.Count != 0)
                                {
                                    op = operators.Pop().ToString();
                                    if (op != "(")
                                    {
                                        expback_arraylist.Add(op);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            default:
                                return new ArrayList();
                        }
                    }
                }
                while (operators.Count != 0)
                {
                    expback_arraylist.Add(operators.Pop().ToString());
                }
                return expback_arraylist;
            }

            /// <summary>
            /// 计算一个ArrayList类型的后缀表达式的值
            /// </summary>
            /// <param name="expback">ArrayList</param>
            /// <returns></returns>
            public static double ExpValue(ArrayList expback)
            {
                double num1, num2, result = 0;
                Stack num = new Stack();
                foreach (string n in expback)
                {
                    if (IsNumberExp(n))
                    {
                        num.Push(n);
                    }
                    else
                    {
                        num2 = Convert.ToDouble(num.Pop());
                        num1 = Convert.ToDouble(num.Pop());
                        result = account(num1, num2, n);
                        num.Push(result);
                    }
                }
                return result;
            }

            //返回本类的表达式值
            public static double ExpValue()
            {
                ArrayList a1 = new ArrayList();
                ArrayList a2 = new ArrayList();
                a1 = Toexp_arraylist(Expresstion);
                a2 = Toexpback_arraylist(a1);
                return ExpValue(a2);
            }

        }
    }
    }
}
