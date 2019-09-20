using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

public class Calculator
{
    public static string[] op = new string[] { "+", "-", "*", "/" }; //初始化运算符

    //生成表达式avd
    public static string mkfun()
    {
        Random r = new Random(Guid.NewGuid().GetHashCode());//解决随机数重复的问题
        StringBuilder build = new StringBuilder();
        int count = r.Next(2, 4);    // 运算符个数
        int start = 0;
        int num1 = r.Next(1, 101);   // 范围内随机数
        build.Append(num1);         // 第一个数字
        for (start = 0; start <= count; start++)
        {
            int idx = r.Next(0, 4);      // 随机运算符
            int num2 = r.Next(1, 101);   // 范围内随机数
            build.Append(op[idx]).Append(num2); // 运算符 连接 随机数
            start++;
        }
        return build.ToString();
    }
    //计算四则运算表达式结果
    public static string Solve(string question)
    {
        DataTable dt = new DataTable();
        string ans = dt.Compute(question, null).ToString(); // 将算式部分计算出结果并转为字符串
        if (double.Parse(ans) % 1 != 0) // 如果结果是个小数，则返回null
        {
            return null;
        }

        return ans;
    }

    public static void Main(string[] args)
    {
        StreamWriter streamWriter = new StreamWriter(@"C:\Users\MagicBook\Desktop\xu.txt", true);
        List<string> list = new List<string>();
        Console.Write("请输入想要生成的个数：");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string question = mkfun();
            string answer = Solve(question);
            if (answer == null) // 如果是个小数，则continue
            {
                i--; continue;
            }
            list.Add(question + "=" + answer);
            Console.WriteLine(question + "=" + answer);

        }
        Console.WriteLine(string.Join("", list.ToArray()));
        foreach (string s in list)
        {
            streamWriter.WriteLine(s);
        }
        Console.ReadLine();
    }
}