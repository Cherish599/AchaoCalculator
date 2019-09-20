using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primarymath
{
    public class Opterator
    {
        //两个运算符
        public static int optwo(int n1, int n2, int n3, int s1, int s2, char[] oper)
        {
            int flag = 0;
            //if ((oper[s1] == '+' || oper[s1] == '-') && (oper[s2] == '*' || oper[s2] == '/'))
            if ((s1 / 2) == 0 && (s2 / 2) == 1)
            {
                double sum = Linkup.arith(n2, n3, s2);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith(n1, (int)sum, s1);
                        if (temp >= 0)
                        {
                            if (Linkup.nonnegint(temp))
                            {
                                flag = 1;
                                Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "=" + (int)temp);
                                Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "=" + (int)temp + "\r\n");
                            }
                        }
                    }
                }
            }
            else
            {
                double sum = Linkup.arith(n1, n2, s1);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith((int)sum, n3, s2);
                        if (temp >= 0)
                        {
                            if (Linkup.nonnegint(temp))
                            {
                                flag = 1;
                                Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "=" + (int)temp);
                                Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "=" + (int)temp + "\r\n");
                            }
                        }
                    }
                }
            }
            return flag;
        }
        //三个运算符
        public static int opthree(int n1, int n2, int n3, int n4, int s1, int s2, int s3, char[] oper)
        {
            int flag = 0;
            //if ((oper[s1] == '+' || oper[s1] == '-') && (oper[s2] == '*' || oper[s2] == '/') && (oper[s3] == '*' || oper[s3] == '/'))
            if ((s1 / 2) == 0 && (s2 / 2) == 1 && (s3 / 2) == 1)
            {
                double sum = Linkup.arith(n2, n3, s2);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith((int)sum, n4, s3);
                        if (temp >= 0)
                        {
                            double temp1 = Linkup.arith(n1, (int)temp, s1);
                            if (temp1 >= 0)
                            {
                                if (Linkup.nonnegint(temp1))
                                {
                                    flag = 1;
                                    Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1);
                                    Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1 + "\r\n");
                                }
                            }
                        }
                    }
                }
            }
            else if ((s1 / 2) == 0 && (s2 / 2) == 1 && (s3 / 2) == 0)
            {
                double sum = Linkup.arith(n2, n3, s2);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith(n1, (int)sum, s1);
                        if (temp >= 0)
                        {
                            double temp1 = Linkup.arith((int)temp, n4, s3);
                            if (temp >= 0)
                            {
                                if (Linkup.nonnegint(temp1))
                                {
                                    flag = 1;
                                    Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1);
                                    Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1 + "\r\n");
                                }
                            }
                        }
                    }
                }
            }
            else if ((s1 / 2) == 0 && (s2 / 2) == 0 && (s3 / 2) == 1)
            {
                double sum = Linkup.arith(n3, n4, s3);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith(n1, n2, s1);
                        if (temp >= 0)
                        {
                            double temp1 = Linkup.arith((int)temp, (int)sum, s2);
                            if (temp1 >= 0)
                            {
                                if (Linkup.nonnegint(temp1))
                                {
                                    flag = 1;
                                    Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1);
                                    Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1 + "\r\n");
                                }
                            }
                        }
                    }
                }
            }
            else if ((s1 / 2) == 1 && (s2 / 2) == 0 && (s3 / 2) == 1)
            {
                double sum = Linkup.arith(n1, n2, s1);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith(n3, n4, s3);
                        if (temp >= 0)
                        {
                            double temp1 = Linkup.arith((int)sum, (int)temp, s2);
                            if (temp1 >= 0)
                            {
                                if (Linkup.nonnegint(temp1))
                                {
                                    flag = 1;
                                    Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1);
                                    Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1 + "\r\n");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                double sum = Linkup.arith(n1, n2, s1);
                if (sum >= 0)
                {
                    if (Linkup.nonnegint(sum))
                    {
                        double temp = Linkup.arith((int)sum, n3, s2);
                        if (temp >= 0)
                        {
                            double temp1 = Linkup.arith((int)temp, n4, s3);
                            if (temp1 >= 0)
                            {
                                if (Linkup.nonnegint(temp1))
                                {
                                    flag = 1;
                                    Console.WriteLine(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1);
                                    Input.sw1.Write(n1 + "" + oper[s1] + "" + n2 + "" + oper[s2] + "" + n3 + "" + oper[s3] + n4 + "=" + (int)temp1 + "\r\n");
                                }
                            }
                        }
                    }
                }
            }
            return flag;
        }
    }
}