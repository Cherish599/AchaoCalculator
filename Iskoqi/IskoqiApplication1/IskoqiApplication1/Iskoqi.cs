using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

 namespace IskoqiApplication1
{
    public class Iskoqi
    {
        int p1, p2, p3,a,b;
        char yn='a';
        Random rand = new Random();//生成随机数的对象
        public Iskoqi(char yn)
        {
            this.yn = yn;
        }
        public void size(int n)//四则运算函数
        {

            for (int i = 1; i <= n; i++)
            {
                 p1 = rand.Next(1,101);
                 p2 = rand.Next(1,101);
                 p3 = rand.Next(1,101);//生成随机数字
                 a = rand.Next(4);
                 b = rand.Next(4);
                 //int j = 0;
                 char[] ab = {'+','-','*','/'};//生成随机运算符
                 string result3 = p1.ToString() + ab[a].ToString() + p2.ToString() + ab[b].ToString() + p3.ToString();
                  DataTable dt = new DataTable();
            object ob = null;
            ob = dt.Compute(result3, "");
            if (Convert.ToInt32(ob) < 0 || ob.ToString().Contains("."))    //结果出现负数与分数，则重新生成
            {
                n++;
            }
            else
            {
                if (yn == 'Y' || yn == 'y')
                    Console.WriteLine(result3 + "=" + ob.ToString());
                if (yn == 'N' || yn == 'n')
                    Console.WriteLine(result3 + "=");
            }
            }

        }
    }
}
