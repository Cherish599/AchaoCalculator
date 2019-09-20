using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class getNum
    {
        private static char[] size = { '+', '-', '*', '/' };
        public string getnum()
        {
            int x, y, z, t;
            
            Random random = new Random();
            z = random.Next(2, 4);//作为随机运算符个数

            string str;
            x = random.Next(0, 100);//作为随机数值
            str = Convert.ToString(x);

            for (int i = 0; i < z; i++)
            {
                 t = random.Next(0, 4);//作为随机运算符下标
                 y = random.Next(0, 100);
                 str += size[t] + Convert.ToString(y);//拼接字符串
                 System.Threading.Thread.Sleep(50);//由于时间间隔太短，需要设置程序睡眠
            }
            return str;
        }
    }
}
