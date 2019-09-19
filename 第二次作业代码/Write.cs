using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Write
    {
        public void write(string[] s,int n)
        {
            FileStream fileStream1 = new FileStream("题表1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fileStream1.Close();
            FileStream fileStream = new FileStream("题表.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fileStream.Close();

            using (StreamWriter sw = new StreamWriter("题表.txt"))
            {
                for(int i=0;i<n;i++)
                {
                    sw.WriteLine(s[i]);
                }
               
            }
            using (StreamWriter sw = new StreamWriter("题表1.txt"))
            {
                for (int i = n; i < 2*n; i++)
                {
                    sw.WriteLine(s[i]);
                }
                
            }
        }
    }
}
