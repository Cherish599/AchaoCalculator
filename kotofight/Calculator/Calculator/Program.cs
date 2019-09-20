using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

public class Calculator
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = new char[] { '+', '-', '*', '/' };
        char[] w = new char[] { '+', '-', '*', '/' };
        char[] p = new char[] { '+', '-', '*', '/' };
        string Res = "";
        int iSeed = 10;
        Random ro = new Random(10);
        long tick = DateTime.Now.Ticks;
        Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));
        Random nums = new Random();
        Random num = new Random();
        for (int i = 0; i < n; i++)
        {
            int Num = num.Next(0,2);
            int Num1 = ro.Next(0, 100);
            int Num2 = ro.Next(0, 100);
            int Num3 = ro.Next(0, 100);
            int Num4 = ro.Next(0, 100);
            int Nums = nums.Next(0, 4);
            int Numm = nums.Next(0, 4);
            int Numn = nums.Next(0, 4);
            if (Nums ==3&&Num1%Num2!=0)
            {
                if (Num2 == 0)
                {
                    if (Num1 == 0)
                    {
                        Num2 = Num3;
                    }
                    else
                    {
                        Num2 = Num1;
                    }
                    
                }
                Num1 = Num1 - (Num1 % Num2);
                
            }
            if (Numm == 3 && Num2 % Num3 != 0)
            {
                if (Num3 == 0)
                {
                    if (Num2 == 0)
                    {
                        Num3 = Num4;
                    }
                    else
                    {
                        Num3 = Num2;
                    }
                }
                Num2 = Num2 - (Num2 % Num3);
                
            }
            if (Numn == 3 && Num3 % Num4 != 0)
            {
                if (Num4 == 0)
                {
                    if (Num3 == 0)
                    {
                        Num4 = 1;
                    }
                    else
                    {
                        Num4 = Num3;
                    }
                }
                Num3 = Num3 - (Num3 % Num4);
            }
            if (Num == 0)
            {
                Console.WriteLine(Num1.ToString() + s[Nums].ToString() + Num2.ToString() + w[Numm].ToString() + Num3.ToString() + "=");
               
                Res = Res + Num1.ToString() + s[Nums].ToString() + Num2.ToString() + w[Numm].ToString() + Num3.ToString() + "=" + "  ";
            }
            else
            {
                Console.WriteLine(Num1.ToString() + s[Nums].ToString() + Num2.ToString() + w[Numm].ToString() + Num3.ToString() + p[Numn].ToString() + Num4.ToString() + "=");
                Res = Res + Num1.ToString() + s[Nums].ToString() + Num2.ToString() + w[Numm].ToString() + Num3.ToString() + p[Numn].ToString() + Num4.ToString() + "=" + "  ";
            }
       
        }
        Console.ReadLine();
        System.IO.File.WriteAllText("E:/dreamworld/dreamworld/kotofight/Calculator/Calculator/subject.txt", Res);
    }  
}