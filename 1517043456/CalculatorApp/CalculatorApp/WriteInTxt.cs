using System;
using System.Diagnostics;
using System.IO;

namespace Calculator
{
    public class WriteInTxt
    {
        public void WriteTxt(string result)
        {
            try
            {
                string txtfile = "F:\\subject.txt";
                StreamWriter sw = new StreamWriter(txtfile);
                sw.Write(result);
                sw.Flush();
                sw.Close();
                Console.WriteLine("写入F://subject.txt完毕！");
            }
            catch (Exception e) {
                Console.WriteLine("文件写入失败！");
            }
        }
    }
}
