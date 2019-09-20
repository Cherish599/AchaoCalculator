using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    public class Makefour
    {
        public String[] fun4(int num)
        {
            char[] opt = new char[4] { '+', '-', '×', '÷' };
            int a, b, c,d, opt1, opt2, opt3, res1 = 0, res2 = 0, res3=0, temp;
            bool flag1, flag2, flag3, changed;
            ArrayList shizi = new ArrayList();
            Random rd = new Random();
            int count = 0;
            for (int i = 0; ; i++)
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

                opt2 = rd.Next(1, 5);            
                c = rd.Next(1, 100);
                flag2 = false;
                while (true)
                {
                    // 如果第一部分能够符合标准，确定第一个式子
                    if (flag2)
                        break;
                    else
                    {
                        opt2 = rd.Next(1, 4);
                        c = rd.Next(1, 100);
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
                                temp = c; c = res1; res1 = temp;
                                flag2 = true;
                                res2 = c- res1;
                            }
                            break;
                        case 3:
                            if (c * res1 < 100)
                            {
                                flag2 = true;
                                res2 = c * res1;
                            }
                            break;
                        case 4:
                            if (res1 %c == 0)
                            {
                                flag2 = true;
                                res2 = res1 % c;
                            }
                            else if (c % res1 == 0)
                            {
                                temp = res1; res1 = c; c = temp;
                                flag2 = true;
                                res2 = res1 % c;
                            }
                            break;
                    }
                }



                // 第三部分 
                opt3 = rd.Next(1, 5);
                d = rd.Next(1, 100);
                flag3 = false;
                changed = false;
                while (true)
                {
                    if (flag3)
                        break;
                    else
                    {
                        opt3 = rd.Next(1, 4);
                        d = rd.Next(1, 100);
                        changed = false;
                    }
                    switch (opt3)
                    {
                        case 1:
                            if (res2 + d < 100)
                            {
                                flag3 = true;
                                res3 = res2 + d;
                            }
                            break;
                        case 2:
                            if (res2 - d > 0)
                            {
                                flag3 = true;
                                res3 = res2 - d;
                            }
                            else
                            {
                                temp = res2; res2 = d; d = temp;
                                flag3 = true;
                                res3 = res2 - d;
                                changed = true;
                            }
                            break;
                        case 3:
                            if (res2 * d < 100)
                            {
                                flag3 = true;
                                res3 = res2 * d;
                            }
                            break;
                        case 4:
                            if (res2 % d == 0)
                            {
                                flag3 = true;
                                res3 = res2 / d;
                            }
                            else if (d % res2 == 0)
                            {
                                temp = res2; res2 = d; d = temp;
                                flag3 = true;
                                res3 = res2 / d;
                                changed = true;
                            }
                            break;
                    }
                }
                if (opt1 <=2 && opt2 <= 2 && opt3 <=2)
                {
                    if (changed) //如果符号改变
                        if (opt1 <= 2 && opt2 > 2)
                            shizi.Add(res2.ToString() + opt[opt3 - 1] + "(" + a.ToString() + opt[opt1 - 1] + b.ToString() + ")" + opt[opt2 - 1] + c.ToString() + "=" + res3.ToString());
                        else if (opt1 > 2 && opt2 <= 2 && opt3 > 2)
                            shizi.Add(res2.ToString() + opt[opt3 - 1] + a.ToString() + opt[opt1 - 1] + "(" + b.ToString() + opt[opt2 - 1] + c.ToString() + ")" + "=" + res3.ToString());
                        else
                            shizi.Add(res2.ToString() + opt[opt3 - 1] + a.ToString() + opt[opt1 - 1] + b.ToString() + opt[opt2 - 1] + c.ToString() + "=" + res3.ToString());
                    else
                   if (opt1 <= 2 && opt2 > 2)
                        shizi.Add("(" + a.ToString() + opt[opt1 - 1] + b.ToString() + ")" + opt[opt2 - 1] + c.ToString() + opt[opt3 - 1] + d.ToString() + "=" + res3.ToString());
                    else if (opt1 > 2 && opt2 <= 2 && opt3 > 2)
                        shizi.Add(a.ToString() + opt[opt1 - 1] + "(" + b.ToString() + opt[opt2 - 1] + c.ToString() + ")" + opt[opt3 - 1] + d.ToString() + "=" + res3.ToString());
                    else
                        shizi.Add(a.ToString() + opt[opt1 - 1] + b.ToString() + opt[opt2 - 1] + c.ToString() + opt[opt3 - 1] + d.ToString() + "=" + res3.ToString());
                    count++;
                }
               
                if (count >= num) break;
            }
            return (string[])shizi.ToArray(typeof(string));
        }
    }
}
