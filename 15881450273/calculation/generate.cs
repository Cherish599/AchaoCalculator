using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    class generate
    {
        public String[] fun(int num)
        {
            char[] opt = new char[4] { '+', '-', '×', '÷'};
            int a, b, c, opt1, opt2, res1=0, res2=0, temp;
            bool flag1, flag2, changed;
            ArrayList shizi = new ArrayList();
            Random rd = new Random();
            for(int i = 0; i < num; i++)
            {
                opt1 = rd.Next(1, 5);
                a = rd.Next(1, 100);
                b = rd.Next(1, 100);
                flag1 = false;
                while (true)
                {
                    // 如果第一部分能够符合标准，确定第一个式子
                    if (flag1)
                        break;
                    else
                    {
                        a = rd.Next(1, 100);
                        b = rd.Next(1, 100);
                    }
                    switch (opt1)
                    {
                        case 1:
                            if (a + b < 100)
                            {
                                flag1 = true;
                                res1 = a + b;
                            }
                            break;
                        case 2:
                            if (a - b > 0)
                            {
                                flag1 = true;
                                res1 = a - b;
                            }
                            else
                            {
                                temp = a; a = b; b = temp;
                                flag1 = true;
                                res1 = a - b;
                            }
                            break;
                        case 3:
                            if (a * b < 100)
                            {
                                flag1 = true;
                                res1 = a * b;
                            }
                            break;
                        case 4:
                            if (a % b == 0)
                            {
                                flag1 = true;
                                res1 = a / b;
                            }
                            else if (b % a == 0)
                            {
                                temp = a; a = b; b = temp;
                                flag1 = true;
                                res1 = a / b;
                            }
                            break;
                    }
                }
                // 第二部分 
                opt2 = rd.Next(1, 5);
                c = rd.Next(1, 100);
                flag2 = false;
                changed = false;
                while (true)
                {
                    if (flag2)
                        break;
                    else
                    {
                        opt2 = rd.Next(1, 4);
                        c = rd.Next(1, 100);
                        changed = false;
                    }
                    switch (opt2)
                    {
                        case 1:
                            if (res1 + c < 100)
                            {
                                flag2 = true;
                                res2 = res1 + c;
                            }
                            break;
                        case 2:
                            if (res1 - c > 0)
                            {
                                flag2 = true;
                                res2 = res1 - c;
                            }
                            else
                            {
                                temp = res1; res1 = c; c = temp;
                                flag2 = true;
                                res2 = res1 - c;
                                changed = true;
                            }
                            break;
                        case 3:
                            if (res1 * c < 100)
                            {
                                flag2 = true;
                                res2 = res1 * c;
                            }
                            break;
                        case 4:
                            if (res1 % c == 0)
                            {
                                flag2 = true;
                                res2 = res1 / c;
                            }
                            else if (c % res1 == 0)
                            {
                                temp = res1; res1 = c; c = temp;
                                flag2 = true;
                                res2 = res1 / c;
                                changed = true;
                            }
                            break;
                    }
                }
                if (changed)
                    if (opt1 > 2 && opt2 <= 2)
                        shizi.Add(res1.ToString() + opt[opt2 - 1] + a.ToString() + opt[opt1 - 1] + b.ToString() + "=" + res2.ToString());
                    else
                        shizi.Add(res1.ToString() + opt[opt2 - 1] + "(" + a.ToString() + opt[opt1 - 1] + b.ToString() + ")=" + res2.ToString());
                else
                    if (opt1 <= 2 && opt2 > 2)
                    shizi.Add("(" + a.ToString() + opt[opt1 - 1] + b.ToString() + ")" + opt[opt2 - 1] + c.ToString() + "=" + res2.ToString());
                else
                    shizi.Add(a.ToString() + opt[opt1 - 1] + b.ToString() + opt[opt2 - 1] + c.ToString() + "=" + res2.ToString());
            }
            return  (string[])shizi.ToArray(typeof(string));
        }
    }
}
