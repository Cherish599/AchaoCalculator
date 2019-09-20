using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculation
{
    public class equality
    {
        public int  Desing()
        {
            int a, b, opt1, res1 = 0, temp;
            bool flag1;
            char[] opt = new char[4] { '+', '-', '×', '÷' };
            Random rd = new Random();
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
            return 1;
        }
    }
}
