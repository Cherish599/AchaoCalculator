using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class line
    {
        protected int num1=0, num2=0, num3=0, num4=0;
        protected char op1 ='#', op2='#', op3='#';
        protected int sum = 0;

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Num3 { get => num3; set => num3 = value; }
        public int Num4 { get => num4; set => num4 = value; }
        public char Op1 { get => op1; set => op1 = value; }
        public char Op2 { get => op2; set => op2 = value; }
        public char Op3 { get => op3; set => op3 = value; }

        protected List<string> lstring = new List<string>();

        /*
        * Comments : 计算list的乘除法
        * Param bool multi : 是否做乘法
        * Author : vchopin
        * @Return void
        */
        protected void calMulSum(bool multi)
        {
            string str = "÷";
            if (multi)
                str = "×";
            while (lstring.Contains(str))
            {
                int cursor = lstring.IndexOf(str);
                if (multi)
                    sum = Convert.ToInt32(lstring[cursor - 1]) * Convert.ToInt32(lstring[cursor + 1]);
                else
                    sum = Convert.ToInt32(lstring[cursor - 1]) / Convert.ToInt32(lstring[cursor + 1]);
                lstring.RemoveAt(cursor);
                lstring.RemoveAt(cursor);
                lstring[cursor - 1] = sum.ToString();
            }
        }

        /*
        * Comments : 计算list的加减法
        * Author : vchopin
        * @Return void
        */
        protected void calAddSum()
        {
            int i = lstring.Count;
            for (int j = 1; j <= i - 2; j += 2)
            {
                if (lstring[j] == "+")
                    sum = Convert.ToInt32(lstring[j - 1]) + Convert.ToInt32(lstring[j + 1]);
                if (lstring[j] == "-")
                    sum = Convert.ToInt32(lstring[j - 1]) - Convert.ToInt32(lstring[j + 1]);
                if ((j == 1 && i >= 3) || (j == 3 && i >= 5))
                {
                    lstring[j + 1] = sum.ToString();
                }

            }
        }

    }
}
