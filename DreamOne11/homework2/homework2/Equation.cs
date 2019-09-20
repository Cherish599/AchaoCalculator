using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    public class Equation
    {
       
        public static string creatEquation()
        {
            
            char[] symbol = { '+', '-', '*', '/' };
            string formula=null;
            Random ran = new Random();
            int numOne=ran.Next(0,101);
            int numX;
            int index;
            int symbolNum = ran.Next(2, 4);
            List<int> result = new List<int>();
            formula = formula+numOne;
            //循环生成计算式，因为有几个运算符就要循环几次
            for (int i=0;i<symbolNum;i++)
            {
                numX = ran.Next(0, 101);
                index = ran.Next(0, 4);
                if(!result.Contains(index))//生成不重复随机数
                {
                    result.Add(index);
                }
                else 
                {
                    symbolNum++;
                    continue;
                }

                if (numX == 0) //防止除数为0
                {
                    continue;
                }

                formula = formula + symbol[index] + numX;

            }

            return formula;
        }
    }
}
