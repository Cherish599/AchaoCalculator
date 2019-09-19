using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUOXUFAXIAN
{
    class Program
    {
        public class FH//运用随机数随机出运算符
        {
            public string fuhao(int fuhao)
            {
                switch (fuhao)
                {
                    case 1:
                        return "+";
                    case 2:
                        return "-";
                    case 3:
                        return "*";
                    case 4:
                        return "/";
                }
                return "0";
            }
        }


        static void Main(string[] args)
        {
            Random N = new Random();
            int n;
            Console.Write("需要的题目数为：");
            n = int.Parse(Console.ReadLine());

            //题目的输出
            for (int i = 0; i < n; i++)
            {
                int fuhao_1 = N.Next(1, 5);
                int fuhao_2 = N.Next(1, 5);
                FH FUHAO = new FH();

                List<int> TIMU = new List<int>();
                int timu = N.Next(2, 4);
                for (int j = 0; j < timu; j++)
                {
                    TIMU.Add(N.Next(1, 101));  //运用随机数随机出题目所需的数字
                }


                if (TIMU.Count == 2)  //当题目中数字个数为两个的处理
                {
                    if (fuhao_1 == 4) //排除除法中出现小数的情况，让其重新随机
                    {
                        while (TIMU[0] % TIMU[1] != 0)
                        {
                            TIMU[0] = N.Next(1, 101);
                            TIMU[1] = N.Next(1, 101);
                        }
                    }
                    Console.WriteLine(TIMU[0] + " " + FUHAO.fuhao(fuhao_1) + " " + TIMU[1] + " " + "=");
                    //两个数的式子运算答案
                    if (fuhao_1 == 1)
                        Console.WriteLine("答案为：" + (TIMU[0] + TIMU[1]));
                    if (fuhao_1 == 2)
                        Console.WriteLine("答案为：" + (TIMU[0] - TIMU[1]));
                    if (fuhao_1 == 3)
                        Console.WriteLine("答案为：" + (TIMU[0] * TIMU[1]));
                    if (fuhao_1 == 4)
                        Console.WriteLine("答案为：" + (TIMU[0] / TIMU[1]));
                }


                if (TIMU.Count == 3)  //当题目中数字个数为三个的处理
                {
                    if (fuhao_1 == 4)   //排除第一个运算符为除法中出现小数的情况，让其重新随机
                    {
                        while (TIMU[0] % TIMU[1] != 0)
                        {
                            TIMU[0] = N.Next(1, 101);
                            TIMU[1] = N.Next(1, 101);
                        }
                    }
                    if (fuhao_2 == 4)
                    {
                        while (TIMU[1] % TIMU[2] != 0)  //排除第二个运算符为除法中出现小数的情况，让其重新随机
                        {
                            TIMU[1] = N.Next(1, 101);
                            TIMU[2] = N.Next(1, 101);
                        }
                    }
                    Console.WriteLine(TIMU[0] + " " + FUHAO.fuhao(fuhao_1) + " " + TIMU[1] + " " + FUHAO.fuhao(fuhao_2) + " " + TIMU[2] + " " + "=");
                    //三个数的式子运算答案
                    if (fuhao_1 == 1)
                    {
                        if (fuhao_2 == 1)
                            Console.WriteLine("答案为：" + (TIMU[0] + TIMU[1] + TIMU[2]));
                        if (fuhao_2 == 2)
                            Console.WriteLine("答案为：" + (TIMU[0] + TIMU[1] - TIMU[2]));
                        if (fuhao_2 == 3)
                            Console.WriteLine("答案为：" + (TIMU[0] + TIMU[1] * TIMU[2]));
                        if (fuhao_2 == 4)
                            Console.WriteLine("答案为：" + (TIMU[0] + TIMU[1] / TIMU[2]));
                    }
                    if (fuhao_1 == 2)
                    {
                        if (fuhao_2 == 1)
                            Console.WriteLine("答案为：" + (TIMU[0] - TIMU[1] + TIMU[2]));
                        if (fuhao_2 == 2)
                            Console.WriteLine("答案为：" + (TIMU[0] - TIMU[1] - TIMU[2]));
                        if (fuhao_2 == 3)
                            Console.WriteLine("答案为：" + (TIMU[0] - TIMU[1] * TIMU[2]));
                        if (fuhao_2 == 4)
                            Console.WriteLine("答案为：" + (TIMU[0] - TIMU[1] / TIMU[2]));
                    }
                    if (fuhao_1 == 3)
                    {
                        if (fuhao_2 == 1)
                            Console.WriteLine("答案为：" + (TIMU[0] * TIMU[1] + TIMU[2]));
                        if (fuhao_2 == 2)
                            Console.WriteLine("答案为：" + (TIMU[0] * TIMU[1] - TIMU[2]));
                        if (fuhao_2 == 3)
                            Console.WriteLine("答案为：" + (TIMU[0] * TIMU[1] * TIMU[2]));
                        if (fuhao_2 == 4)
                            Console.WriteLine("答案为：" + (TIMU[0] * TIMU[1] / TIMU[2]));
                    }
                    if (fuhao_1 == 4)
                    {
                        if (fuhao_2 == 1)
                            Console.WriteLine("答案为：" + (TIMU[0] / TIMU[1] + TIMU[2]));
                        if (fuhao_2 == 2)
                            Console.WriteLine("答案为：" + (TIMU[0] / TIMU[1] - TIMU[2]));
                        if (fuhao_2 == 3)
                            Console.WriteLine("答案为：" + (TIMU[0] / TIMU[1] * TIMU[2]));
                        if (fuhao_2 == 4)
                            Console.WriteLine("答案为：" + (TIMU[0] / TIMU[1] / TIMU[2]));
                    }
                }
            }
        }
    }
}