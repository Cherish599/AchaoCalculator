using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class Newrandow
    {

        Random random = new Random();
        string[] symbol = { "+", "-", "*", "/" };
        public int RandInt()
        {
            return random.Next(1, 100);
        }

        public string RandSymbol()
        {
            return symbol[random.Next(0, 4)];
        }

        public int Randm()
        {
            return random.Next(2, 4);
        }
    }
}
