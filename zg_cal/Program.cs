using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class Program
    {
       
        static void Main(string[] args)
        {
            while (true)
            {
                //int ques_nums = 1;
                Console.Write("Do you want to get some(10) new math-questions? ");
                Console.Write("enter yes or no:");
                String input = Console.ReadLine();
                if (input.Equals("yes"))
                {
                    Index index = new Index();
                    for (int i = 0; i < 100; i++)
                    {
                        //String ques = "the "+(i+1)+"th problems:";
                        String ques = index.question();
                        if (ques == "wrong!")
                            i--;
                        else
                        {
                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"E:\achao_cal.txt", true))
                                {
                                        file.WriteLine(ques);
                                }
                        }
                    }
                }
                else break;

                //Console.WriteLine("success! ");
            }
        }
    }
}
