using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> list = new List<Question>();
            
           
            Context easy = new Context(new SimpleQuestionBuilder());
            Context medium = new Context(new MediumQuestionBuilder());
            
           
            Random random = new Random();
            Console.WriteLine("请输入想要生成的题目的数量：");
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                int n = random.Next(2);
                if (n == 0)
                {
                    list.Add(easy.buildQuestion());
                }
                else
                {
                    list.Add(medium.buildQuestion());
                }
            }
            //写入文件
            FileWriteUtil.writer(list);
            Console.WriteLine("生成成功，按任意键退出");
            Console.ReadLine(); //防止退出

           
        }
    }
}
