using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace cee
{
    class CreatFile//这是一个储存算式到文本文件的一个类
    {
        public CreatFile(string st)
        {
            StreamWriter sw = new StreamWriter("D:/subject.txt", true)；
            sw.WriteLine(st);
            sw.Close();

        }
    }
}
