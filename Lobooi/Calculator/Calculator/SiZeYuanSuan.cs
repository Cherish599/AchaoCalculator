using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SiZeYuanSuan
    {
        int num_g, num_f;
        public double[] Result;
        Random rdm = new Random();

        //构造函数，传值
        public SiZeYuanSuan(int num_g, int num_f)
        {
            this.num_g = num_g;
            this.num_f = num_f; 
            Result = new double[num_g];

        }
        

        //产出随机运算
        public void YunSuanSC() 
        {
            for (int i = 0; i < num_g; i++) 
            {
                int a = rdm.Next(num_f) + 1;//生成第一个数
                int b = rdm.Next(num_f) + 1;//生成第二个数

                char f = YunSuanFu();//取出运算符

                Console.WriteLine("{0}、{1} {2} {3} = ", i + 1, a, f, b);
                
                if (f == '+') { Result[i] = a + b; }
                else if (f == '-') { Result[i] = a - b; }
                    else if (f == '*') { Result[i] = a * b; }
                           else { Result[i] = Math.Round( Convert.ToDouble(a) / b,3); }


            }
        }
        //产出随机运算符
        char YunSuanFu()
        {
            int k = rdm.Next(4);
            char fu = '+';
            switch (k) 
            {
                case 0: fu = '+';break;
                case 1: fu = '-';break;
                case 2: fu = '*';break;
                case 3: fu = '/';break;
            }
           // Console.WriteLine(fu);
            return fu;
        }

        //查看答案
        public void SeeResult()
        {
            foreach (double i in Result) 
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
