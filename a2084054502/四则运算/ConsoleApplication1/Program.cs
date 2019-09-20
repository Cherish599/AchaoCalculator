using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApplication1
{
 public    class Program
 {
     public void GreatCalculation(int n)
     {
         bool test = false;
         Random r = new Random();
         int op = r.Next(2, 4);//符号数
         List<int> l = new List<int>();
         List<int> f = new List<int>();
         for (int li = 0; li < n; )
         {
             for (int i = 0; i < op; i++)
             {
                 f.Add(r.Next(1, 5));

             }
             for (int i = 0; i <= op; i++)
             {
                 l.Add(r.Next(0, 100));
             }
             Dictionary<int, string> h = new Dictionary<int, string> { { 1, "+" }, { 2, "-" }, { 3, "*" }, { 4, "/" } };
             for (int i = 0; i < f.Count(); i++)
             {
                 if (h[f[i]] == "/" && l[i] == 0)
                     test = false;
                 else
                     test = true;
             }
             string str = "";
             for (int i = 0; i < f.Count; )
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

             }
             if (test)
             {
                 test = false;
                 DataTable table = new DataTable();
                 var re = table.Compute(str, null);
                 int s;
                 if (int.TryParse(re.ToString(), out s))
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
         Console.Write("请输入题目个数：");
         int n = Convert.ToInt32(Console.ReadLine());
         Program c = new Program();
         c.GreatCalculation(n);
        }
    }
}
