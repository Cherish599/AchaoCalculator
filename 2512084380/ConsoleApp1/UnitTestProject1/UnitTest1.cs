using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
namespace UnitTestProject1
{
  

    
        class Program
        {

            static void creat(int n)
            {
                Random rand = new Random();
                String[] opes = { "+", "-", "*", "/" };
                Stack<char> stack1 = new Stack<char>();//放运算符
                Stack<int> stack2 = new Stack<int>();//放操作数
                for (int i = 1; i <= n; i++)
                {
                    int j = rand.Next(1, 20);
                    if (j / 2 == 0) j = 2;
                    else j = 3;
                    for (; j > 0; j--)
                    {
                        int b = rand.Next(0, 100);
                        stack2.Push(b);//将操作数压入栈
                        Console.Write(b);
                        int op = rand.Next(1, 16);
                        switch (op)
                        {
                            case 1: case 2: case 3: case 4: stack1.Push('+'); Console.Write('+'); break;//将运算符压入栈
                            case 5: case 6: case 7: case 8: stack1.Push('-'); Console.Write('-'); break;
                            case 9: case 10: case 11: case 12: stack1.Push('*'); Console.Write('*'); break;
                            case 13: case 14: case 15: case 16: stack1.Push('/'); Console.Write('/'); break;
                        }

                    }
                    int c = rand.Next(0, 100);
                    stack2.Push(c);
                    Console.Write(c);
                    Console.Write('=');
                    Console.WriteLine();

                }
            }
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                creat(n);


            }
        }

    }
