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
        public int Sumfour(int x,int y,int z,int w,string s1,string s2,string s3)
        {
            if((s1=="*"||s1=="/")&&(s2=="+"||s2=="-")&&(s3=="+"||s3=="-"))
            {
                return cho.Option(cho.Option(x, s1, y), s2, cho.Option(z, s3, w));
            }
            else if((s1 == "+" || s1 == "-") && (s2 == "*" || s2 == "/") && (s3 == "+" || s3 == "-"))
            {
                return cho.Option(cho.Option(x, s3, w), s1, cho.Option(y, s2, z));
            }
            else if((s1 == "+" || s1 == "-") && (s2 == "+" || s2 == "-") && (s3 == "*" || s3 == "/"))
            {
                return cho.Option(cho.Option(x, s1, y), s2, cho.Option(z, s3, y));
            }
            else if((s1 == "*" || s1 == "/") && (s2 == "*" || s2 == "/") && (s3 == "+" || s3 == "-"))
            {
                int temp = cho.Option(cho.Option(x, s1, y), s2, z);
                return cho.Option(temp, s3, w);
            }
            else if ((s1 == "*" || s1 == "/") && (s2 == "+" || s2 == "-") && (s3 == "*" || s3 == "/"))
            {
                return cho.Option(cho.Option(x, s1, y), s2, cho.Option(z,s3,w));
            }
            else if ((s1 == "+" || s1 == "-") && (s2 == "*" || s2 == "/") && (s3 == "*" || s3 == "/"))
            {
                int temp = cho.Option(cho.Option(y, s2, z), s3, w);
                return cho.Option(x, s1, temp);
            }
            else
            {
                return cho.Option(cho.Option(x, s1, y), s2, cho.Option(z, s3, w));
            }
        }
    }
}
