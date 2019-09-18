using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace cee
{
    class CreatFile
    {
        public CreatFile(string st)
        {
            StreamWriter sw = new StreamWriter("D:/subject.txt", true);
            sw.WriteLine(st);
            sw.Close();

        }
    }
}
