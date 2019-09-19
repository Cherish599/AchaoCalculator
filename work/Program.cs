using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter(@"D:\workplace\vs\subject.txt");
            int n = int.Parse(Console.ReadLine());
            Split split = new Split();
            gets test = new gets();
            while(true)
            {
                List<string> vs = split.Splits();
                test.Gets1(vs);
                int s = test.Gets2();
                if(s>=0)
                {
                    Console.Write(string.Join("", vs.ToArray()));
                    file.Write(string.Join("", vs.ToArray()));
                    Console.Write(" = ");
                    file.Write(" = ");
                    Console.WriteLine(s);
                    file.WriteLine(s);
                    n--;
                }
                else
                {
                    continue;
                }
                if(n==0)
                {
                    break;
                }
            }
            file.Flush();
            file.Close();
        }
    }
}
