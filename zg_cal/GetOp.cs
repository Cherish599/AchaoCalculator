using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class GetOp
    {

        public String getOp(int n)
        {
            int nums = n;
            String options = "";
            for (int i = 0; i < nums; i++)
            {
                options += setOp();
            }
            return options;
        }

        public String setOp()
        {
            switch (Only.r.Next(0, 4))
            {
                case 0:
                    return "+";
                case 1:
                    return "-";
                case 2:
                    return "*";
                case 3:
                    return "/";
                default:
                    return "";
            }
        }
    }
}
