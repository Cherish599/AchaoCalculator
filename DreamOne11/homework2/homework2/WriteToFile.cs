using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace homework2
{
    class WriteToFile
    {
        public static void save(string finallResult)
        {
            try
            {
                if(finallResult!=null)
                {
                    using (StreamWriter sw = new StreamWriter("c:/Users/15199/Desktop/subject.txt", true))
                    {
                        sw.WriteLine(finallResult);
                    }
                }
            }
            catch
            {
                Console.WriteLine("写入文档失败！");
            }
        }
    }
}
