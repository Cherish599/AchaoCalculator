using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    class Program {
        static void Main(string[] args) {
            double a = '9' - '0';
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            sb.Append(125);
            for(int i = 0; i < sb.Length; i++) {
                Console.WriteLine(sb[i]);
            }
            
        }
    }
}
