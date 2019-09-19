using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你需要的四则运算数量：");
            String TotalNum = Console.ReadLine();
            int num = Convert.ToInt32(TotalNum);
            Solve s = new Solve();
            StringBuilder sb = new StringBuilder();
            WriteInTxt wt = new WriteInTxt();
            Console.WriteLine("打印数据中，请等待……");
            //获取题目数量
            while (num > 0)
            {
                string result = s.GetResult();
                Console.WriteLine(result);
                sb.Append(result).Append("\r\n");
                num--;
            }
            //写入文件
            wt.WriteTxt(sb.ToString());
        }
    }
}
