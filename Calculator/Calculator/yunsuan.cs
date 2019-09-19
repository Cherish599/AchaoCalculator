using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class yunsuan
    {
        choicemath cho = new choicemath();
        public int Sum(int x,int y,int z,string sym1,string sym2)                //运算方法
        {
            if ((sym1 == "*"||sym1=="/") || (sym2 =="+"||sym2=="-"))
                return cho.Option(cho.Option(x, sym1, y), sym2, z);
            else
                return cho.Option(x, sym1, cho.Option(y, sym2, z));
            //返回运算结果
        }
    }
}
