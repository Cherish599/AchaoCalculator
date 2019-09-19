using System;
using System.Collections.Generic;
using System.Linq;

namespace aChao_1
{
    public class Unitl
    {
     
        public List<string> delMulAndDiv(List<string> equalString)
        {
            List<string> list = new List<string>();
            int i = equalString.Count()-1;
            while (true)
            {
                Console.WriteLine(string.Join("", equalString.ToArray()));
                if (!equalString.Contains("*") && !equalString.Contains("/"))
                {
                    break;
                }
                if (equalString[i].Equals("*"))
                {
                    equalString[i] = (Convert.ToInt32(equalString[i - 1]) * Convert.ToInt32(equalString[i + 1])).ToString();
                    equalString.RemoveAt(i - 1);
                    equalString.RemoveAt(i);
                    i--;
                }
                if (equalString[i].Equals("÷"))
                {
                    if (equalString[i + 1].Equals("0"))
                    {
                        Console.WriteLine("此算式不合格");
                        equalString.Clear();
                        equalString.Add("-1");
                        break;
                    }
                    equalString[i] = (Convert.ToInt32(equalString[i - 1]) / Convert.ToInt32(equalString[i + 1])).ToString();
                    if(Convert.ToInt32(equalString[i+1])* Convert.ToInt32(equalString[i])!= Convert.ToInt32(equalString[i - 1]))
                    {
                        Console.WriteLine("此算式不合格");
                        equalString.Clear();
                        equalString.Add("-1");
                        break;
                    }
                    equalString.RemoveAt(i - 1);
                    equalString.RemoveAt(i);
                    i--;
                }
                i--;
            }
            Console.WriteLine(string.Join("", equalString.ToArray()));
            return equalString;
        }

        public int writeTxt(List<string> list)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\YM\Desktop\未完成项目\achao_1\test\WriteLines1.txt"))
            {
                foreach (string line in list)
                {
                    file.WriteLine(line);
                }

            }
            return 1;
        }
    }
}
