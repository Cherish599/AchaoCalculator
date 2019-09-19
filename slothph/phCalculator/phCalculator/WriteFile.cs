using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phCalculator;
using System.IO;

namespace phCalculator
{
    public class WriteFile
    {
        //将列表ans中所有的题目，写入到txt文件中
        public static void writeFile(int num)
        {
            string path = @"D:\GitBase\AchaoCalculator\slothph\problem.txt";
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < num; i++)
            {
                sw.WriteLine(Program.ans[i]);
            }
            sw.Close();
        }
    }
}
