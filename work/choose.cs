using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class choose
    {
        public static int Choose(string p)
        {
            if (p == "*" )
            {
                return 1;
            }
           else if(p=="/")
            {
                return 2;
            }
            else if(p=="+")
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
