using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class utils
    {
        choicemath cho = new choicemath();
        public bool judge(string sym1,string sym2,int x,int y,int z)
        {
            if(sym1=="/"&&(x/y*y)!=x)
            {
                return false;
            }
            if(sym2=="/"&&(((sym1=="+"||sym1=="-")&&(y/z*z)!=y)||((sym1=="*"||sym2=="/")&&(cho.Option(x,sym1,y)/z*z)!=cho.Option(x,sym1,y))))
            {
                return false;
            }
            return true;
        }
    }
}
