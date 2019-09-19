using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zlllll
{
    class Program
    {
            static void Main(string[] args)
            {
                string[] oper = { "+", "-", "*", "/" };
                int n;//出多少道题
                Console.WriteLine("需要的出题量");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("出题成功");
                string question = "";
            zlllll._random random = new zlllll._random();   //随机类对象
            zlllll.Compute compute;//四则运算对象
                float res; //运算结果
                           //文件url
                string file1 = @"D:\软件工程作业\第二次\AchaoCalculator\zenglang1\zlllll\zlllll\work.txt";
                string file2 = @"D:\软件工程作业\第二次\AchaoCalculator\zenglang1\zlllll\zlllll\result.txt";
                StreamWriter w1 = new StreamWriter(file1);
                StreamWriter w2 = new StreamWriter(file2);
                for (int i = 0; i < n; i++)
                {
                    question = "";
                    float num;
                    int O;
                    for (int j = 0; j < random.return_num(); j++)
                    {
                        num = random.return_operand();    //储存操作数和操作符代号
                        O = random.return_operator();
                        question += num;
                        switch (O)
                        {
                            case 0:
                                question += oper[0];
                                break;
                            case 1:
                                question += oper[1];
                                break;
                            case 2:
                                question += oper[2];
                                break;
                            case 3:
                                question += oper[3];
                                break;
                        }
                    }
                    num = random.return_operand();
                    question += num;
                    compute = new zlllll.Compute(question);
                    res = compute.run();
                    //若结果不为整数，此次操作无效
                    if (Math.Abs(res - (int)res) != 0)
                    {
                        i--;
                        continue;
                    }
                    question += "=";
                    w1.WriteLine(question);
                    question += res;
                    w2.WriteLine(question);
                }
                w1.Flush();
                w2.Flush();
                w1.Close();
                w2.Flush();
                Console.WriteLine(@"文件已生成url(D:\软件工程作业\第二次\AchaoCalculator\zenglang1\zlllll\zlllll\work.txt) ");
                Console.ReadKey();
            }
        }
      
    }

