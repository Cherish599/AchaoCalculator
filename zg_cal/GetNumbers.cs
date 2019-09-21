using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class GetNumbers
    {
        //static Random r = new Random();

        ////三个操作数
        //private int op_num1=0;
        //private int op_num2 =0;
        //private int op_num3 =0;
        
        public GetNumbers()
        {
            
        }

        public int getNumbers()
        {
            return Only.r.Next(0, 101);
        }

    }
}
