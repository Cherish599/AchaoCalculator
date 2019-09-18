using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    class generate
    {
        public void generatequestion(string input)
        {
            Regex reg = new Regex(@"^[0-9]+$");
            if (!reg.Match(input).Success)
            {
                MessageBox.Show("请输入数字!");
            }
            else
            {
                string[] sym = new string[] { "+", "-", "*", "/" };
                Random random = new Random();
                int t = 0;
                int a, b, c;
                int res = 0;
                char ch1, ch2;
                string s1, s2, line;
                Common.qnumber = int.Parse(input);
                bool flag;
                do
                {
                    flag = false;
                    s1 = sym[random.Next(0, 4)];
                    s2 = sym[random.Next(0, 4)];
                    a = random.Next(0, 101);
                    Thread.Sleep(1);
                    b = random.Next(0, 101);
                    Thread.Sleep(1);
                    c = random.Next(0, 101);
                    Thread.Sleep(1);
                    ch1 = char.Parse(s1);
                    ch2 = char.Parse(s2);
                    switch (ch1)
                    {
                        case '+':
                            switch (ch2)
                            {
                                case '+':
                                    res = a + b + c;
                                    flag = true;
                                    break;
                                case '-':
                                    res = a + b - c;
                                    flag = true;
                                    break;
                                case '*':
                                    res = a + b * c;
                                    flag = true;
                                    break;
                                case '/':
                                    if (c == 0)
                                        continue;
                                    else if(b % c == 0)
                                    {
                                        res = a + b / c;
                                        flag = true;
                                    }
                                    break;
                            }
                            break;
                        case '-':
                            switch (ch2)
                            {
                                case '+':
                                    res = a - b + c;
                                    flag = true;
                                    break;
                                case '-':
                                    res = a - b - c;
                                    flag = true;
                                    break;
                                case '*':
                                    res = a - b * c;
                                    flag = true;
                                    break;
                                case '/':
                                    if (c == 0)
                                        continue;
                                    else if(b % c == 0)
                                    {
                                        res = a - b / c;
                                        flag = true;
                                    }
                                    break;
                            }
                            break;
                        case '*':
                            switch (ch2)
                            {
                                case '+':
                                    res = a * b + c;
                                    flag = true;
                                    break;
                                case '-':
                                    res = a * b - c;
                                    flag = true;
                                    break;
                                case '*':
                                    res = a * b * c;
                                    flag = true;
                                    break;
                                case '/':
                                    if (c == 0)
                                        continue;
                                    else if(b % c == 0)
                                    {
                                        res = a * b / c;
                                        flag = true;
                                    }
                                    break;
                            }
                            break;
                        case '/':
                            if (b == 0)
                                continue;
                            else switch (ch2)
                            {
                                case '+':
                                    if (a % b == 0)
                                    {
                                        res = a / b + c;
                                        flag = true;
                                    }
                                    break;
                                case '-':
                                    if (a % b == 0)
                                    {
                                        res = a / b - c;
                                        flag = true;
                                    }
                                    break;
                                case '*':
                                    if (a % b == 0)
                                    {
                                        res = a / b * c;
                                        flag = true;
                                    }
                                    break;
                                case '/':
                                    if (c == 0)
                                        continue;
                                    else if(a % b % c == 0)
                                    {
                                        res = a / b / c;
                                        flag = true;
                                    }
                                    break;
                            }
                            break;
                    }
                    line = a + " " + ch1 + " " + b + " " + ch2 + " " + c + " = " + res;
                    if (flag == true)
                    {
                        Common.list.Add(line);
                        t++;
                    }
                }while (t <= Common.qnumber);
            }
        }
    }
}
