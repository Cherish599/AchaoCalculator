using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入出题个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            object result;
            DataTable dt = new DataTable();
            while (i < n)
            {
                 getNum getnum1 = new getNum();
                 
                 String str = getnum1.getnum();
                 result = dt.Compute(str, "");
                //如果结果含有小数点，或者表达式中有除以0，或者结果为负数则再次获取一个计算式
                if (result.ToString().Contains(".") || str.Contains("/0") || int.Parse(result.ToString()) < 0)
                      continue;
                 i++;
                 string str1;
                 str1 = str.Replace("/", "÷") + "=" + result.ToString();
                 Console.WriteLine(str1);
                writeFile writefile1 = new writeFile();
                writefile1.writefile(str1);
            }
            //System.Threading.Thread.Sleep(10000);
        }
    }
}
