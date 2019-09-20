using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 个人作业2
{
    class Cal
    {
        public void Calculator(int n)
        {
            bool test = false;
            Random r = new Random();
            int op = r.Next(2, 4);//符号数
            List<int> l = new List<int>();
            List<int> f = new List<int>();
            for (int li = 0; li < n;)
            {
                for (int i = 0; i < op; i++)
                {
                    f.Add(r.Next(1, 5));//随机运算符

                }
                for (int i = 0; i <= op; i++)
                {
                    l.Add(r.Next(0, 100));//随机数范围
                }
                Dictionary<int, string> h = new Dictionary<int, string> { { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" } };
                for (int i = 0; i < f.Count(); i++)//判断除数是否=0
                {
                    if (h[f[i]] == "/" && l[i] == 0)
                        test = false;
                    else
                        test = true;
                }
                string str = "";
                for (int i = 0; i < f.Count;)
                {
                    if (i == 0)
                    {
                        str = l[i].ToString() + h[f[i]].ToString() + l[i + 1].ToString();
                        i += 1;
                    }
                    else
                    {
                        str += h[f[i]].ToString() + l[i + 1].ToString();
                        i += 1;
                    }

                }//生成运算式
                if (test)
                {
                    test = false;
                    DataTable table = new DataTable();
                    var re = table.Compute(str, null);
                    int s;
                    if (int.TryParse(re.ToString(), out s))//判断结果是否为小数
                    {
                        Console.WriteLine(str + "=" + re.ToString());
                        test = true;
                    }
                }
                if (test == true)
                    li++;
                l.Clear();
                f.Clear();
            }

        }
        static void Main(string[] args)
        {
            Console.Write("请输入四则运算题目个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            Cal c = new Cal();
            c.Calculator(n);
        }


    }
}