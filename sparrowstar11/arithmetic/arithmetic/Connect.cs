using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    public class Connect
    {
        //创建一个Random类型的对象
        private Random rd = new Random();
        //随机运算符数组
        private string[] op = { "+", "-", "*", "/" };
        public int randomInt(int m, int n)
        {
            return this.rd.Next(m, n);
        }
        //随机返回运算符
        public string randomop()
        {
            return this.op[this.rd.Next(4)];
        }
        //算式函数
        //n表示运算符的数量
        public List<string> createExpression(int n)
        {
            //创建算式列表，用来存运算符和数值
            List<string> expString = new List<string>();
            for (int i = 0; i < n; i++)
            {
                expString.Add(this.randomInt(1, 100).ToString());
                expString.Add(this.randomop());
            }
            //运算符数量比数值数量少1，所以还要生成一个数字
            expString.Add(this.randomInt(1, 100).ToString());
            return expString;
        }

        //写入文件
        public void Tofile(List<string> list)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"F:\Calculator\AchaoCalculator\sparrowstar11\四则运算题目.txt"))
            {
                foreach (string line in list)
                {
                    file.WriteLine(line);
                }

            }
        }
    }
}
