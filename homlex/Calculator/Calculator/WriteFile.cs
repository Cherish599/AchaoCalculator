using System.Collections.Generic;
using System.IO;

namespace Calculator
{
    public class WriteFile
    {
        public static void save(string path, List<string> formular)
        {
            using (StreamWriter streamWriter = new StreamWriter(@path, true))
            {
                foreach (string line in formular)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}
