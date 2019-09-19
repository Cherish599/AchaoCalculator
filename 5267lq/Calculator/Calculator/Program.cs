using System;
using System.Text;
using System.Data;
using System.IO;
using System.Collections.Generic;

public class Calculator
{
    private static string[] sym = new string[] { "+", "-", "*", "/" }; 
    public static string Get_subject()
    {
        Random ran = new Random(Guid.NewGuid().GetHashCode());
        StringBuilder build = new StringBuilder();
        int j = 0;
        int count = ran.Next(2, 4);    
        int num1 = ran.Next(1, 101);   
        build.Append(num1);         
        for (j = 0; j <= count; j++)
        {
            int idx = ran.Next(0, 4);      
            int num2 = ran.Next(1, 101);   
            build.Append(sym[idx]).Append(num2); 
            j++;
        }
        return build.ToString();
    }   
    public static string Get_result(string question)
    {
        DataTable data = new DataTable();
        string res = data.Compute(question, null).ToString(); 
        if (double.Parse(res) % 1 != 0)
        {
            return null;
        }
        return res;
    }
    public static void Main(string[] args)
    {
        StreamWriter streamWriter = new StreamWriter(@"G:\programs.txt", true);
        List<string> list = new List<string>();
        Console.Write("四则运算题目个数：");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string question = Get_subject();
            string answer = Get_result(question);
            if (answer == null||int.Parse(answer)<0) 
            {
                i--;
                continue;
            }
            list.Add(question + "=" + answer);
            Console.WriteLine(question + "=" + answer);
        }

        foreach (string s in list)
        {
            streamWriter.WriteLine(s);
        }
        Console.ReadLine();
    }
}