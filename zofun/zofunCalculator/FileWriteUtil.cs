using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zofunCalculator
{
    /// <summary>
    /// 写文件工具类
    /// </summary>
    public static class FileWriteUtil
    {
        
        public static void writer(List<Question> list)
        {
            string path = "question.txt";
            StreamWriter sw = new StreamWriter(path, false);
            sw.Write("");
            sw.Close();
            sw = new StreamWriter(path, true);
            foreach(Question q in list)
            {
                sw.WriteLine(string.Format("{0,-30}答案:{1,-10}",q.getExpression()+"=",q.getAnswer()));
            }
            sw.Close();
        }
    }
}
