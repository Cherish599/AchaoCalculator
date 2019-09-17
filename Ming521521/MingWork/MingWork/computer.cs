using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingWork
{
    class computerUtil
    {

        /**
         * 判断是否是数字
         */
        public static bool judgenumber(string text)
        {
            try
            {
                int var1 = Convert.ToInt32(text);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        /*
         * 判断是否是运算符
         */
        public static bool juderoper(string text)
        {
            if (text.Equals("+") || text.Equals("-") || text.Equals("*") || text.Equals("/"))
            {
                return true;
            }
            else
                return false;
        }
        /*
         * 加减乘除
         * 
         */ 
        public static object add(object a,object b)
        {
            int d1 = Int32.Parse(a.ToString());
            int d2 = Int32.Parse(b.ToString());
            return d1 + d2;
        }
        public static object sub(object a,object b)
        {
            int d1 = Int32.Parse(a.ToString());
            int d2=Int32.Parse(b.ToString());
            return d2 - d1;
        }
        public static object mul(object a,object b)
        {
            int d1 = Int32.Parse(a.ToString());
            int d2 = Int32.Parse(b.ToString());
            return d1 * d2;
        }
        public static object div(object a,object b)
        {
            int d1 = Int32.Parse(a.ToString());
            int d2 = Int32.Parse(b.ToString());
            return d2 / d1;
        }
        /*
         * 优先级判断
         */ 
        public static int judgeOperLEV(string text)
        {
            if (text.Equals("+") || text.Equals("-"))
            {
                return 2;
            }
            else return 3;
        }
        /*
         * 运算
         */ 
        public static int operate(string type,string a,string b)
        {
            if (type == "+")
            {
                return Convert.ToInt32(add(a, b));
            }
            else if (type == "-")
            {
                return Convert.ToInt32(sub(a, b));
            }
            else if (type == "*")
            {
                return Convert.ToInt32(mul(a, b));
            }
            else if (type == "/")
            {
                return Convert.ToInt32(div(a, b));
            }
            else
                return 0;
        }



    }
}
