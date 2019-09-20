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
        public bool judge1(string sym1,string sym2,int x,int y,int z)
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
        public bool judge2(string s1,string s2,string s3,int f1,int f2,int f3,int f4)
        {
            if (s1 == "/" && (f1 / f2 * f2) != f1)
            {
                return false;
            }
            else if ((s1 == "-" || s1 == "+") && (s2 == "/" && f2 / f3 * f3 != f2) && (s3 == "*" || s3 == "+" || s3 == "-"))
            {
                return false;

            }
            else if((s1=="-"||s1=="+")&&(s2=="-"||s2=="+")&&(s3=="/"&&f3/f4*f4!=f3))
            {
                return false;
            }
            else if((s1=="/"&&f1/f2*f2!=f1)&&(s2=="/"&&(cho.Option(f1,s1,f2)/f3*f3!=cho.Option(f1,s1,f2))&&(s3=="+"||s3=="-")))
            {
                return false;
            }
            return true;
        }
    }
}
