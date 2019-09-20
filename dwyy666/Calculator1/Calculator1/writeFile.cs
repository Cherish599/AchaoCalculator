using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
   public class writeFile
    {
        public void writefile(string str)
        {

            try
            {
                StreamWriter sw = new StreamWriter("e:\\test.txt", true);
                sw.WriteLine(str);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("文件写入失败！");
            }

            
        }
    }
}
