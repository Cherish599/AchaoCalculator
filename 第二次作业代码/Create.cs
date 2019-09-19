using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Create
    {
        int num1=1, num2=1, num3=1, num4=1;//操作数
        int numop=3;//符号个数
        int optype=1,optype1=1,optype2=2,optype3=3;//操作数类型用数字代表
        char[] op = { '+', '-', '*', '/' };//操作符
        float result=0;//计算值
        string s;//算式字符串

         
        public string[] creatti(int n)
        {
            string[] ti=new string[100];
            
            for (int i = 0; i < n; i++)
            {
                numop = new Random().Next(1, 4);
                for (int j = 0; j < numop + 1; j++)
                {
                    System.Threading.Thread.Sleep(12);
                    num1 = new Random().Next(1, 100);

                    optype = new Random().Next(0, 4);
                    s = s + op[optype] + num1;
                    ti[i] = s;
                }
                
            }
            return ti;
        }

        public string[] creatti1(int n)
        {
            string[] ti = new string[300];           

            for (int i = 0; i < n; i++)
            {
                num1 = new Random().Next(1, 100);
                System.Threading.Thread.Sleep(10);
                num2 = new Random().Next(1, 100);
                System.Threading.Thread.Sleep(10);
                num3 = new Random().Next(1, 100);
                System.Threading.Thread.Sleep(10);
                optype1 = new Random().Next(1, 5);
                System.Threading.Thread.Sleep(10);
                numop = new Random().Next(2, 4);
                
                if (numop == 2)
                    switch (optype1)
                    {
                        case 1:
                            switch (optype2)
                            {
                                case 1:
                                    s = num1.ToString() + op[0] + num2.ToString() + op[0] + num3.ToString();
                                    result = num1 + num2 + num3;
                                    break;
                                case 2:
                                    s = num1.ToString() + op[0] + num2.ToString() + op[1] + num3.ToString();
                                    result = num1 + num2 - num3;
                                    break;
                                case 3:
                                    s = num1.ToString() + op[0] + num2.ToString() + op[2] + num3.ToString();
                                    result = num1 + num2 * num3;
                                    break;
                                case 4:
                                    s = num1.ToString() + op[0] + num2.ToString() + op[3] + num3.ToString();
                                    result = num1 + (float)num2 / num3;
                                    break;
                            }
                            break;
                        case 2:
                            switch (optype2)
                            {
                                case 1:
                                    s = num1.ToString() + op[1] + num2.ToString() + op[0] + num3.ToString();
                                    result = num1 - num2 + num3;
                                    break;
                                case 2:
                                    s = num1.ToString() + op[1] + num2.ToString() + op[1] + num3.ToString();
                                    result = num1 - num2 - num3;
                                    break;
                                case 3:
                                    s = num1.ToString() + op[1] + num2.ToString() + op[2] + num3.ToString();
                                    result = num1 - num2 * num3;
                                    break;
                                case 4:
                                    s = num1.ToString() + op[1] + num2.ToString() + op[3] + num3.ToString();
                                    result = num1 - (float)num2 / num3;
                                    break;
                            }
                            break;
                        case 3:
                            switch (optype2)
                            {
                                case 1:
                                    s = num1.ToString() + op[2] + num2.ToString() + op[0] + num3.ToString();
                                    result = num1 * num2 + num3;
                                    break;
                                case 2:
                                    s = num1.ToString() + op[2] + num2.ToString() + op[1] + num3.ToString();
                                    result = num1 * num2 - num3;
                                    break;
                                case 3:
                                    s = num1.ToString() + op[2] + num2.ToString() + op[2] + num3.ToString();
                                    result = num1 * num2 * num3;
                                    break;
                                case 4:
                                    s = num1.ToString() + op[2] + num2.ToString() + op[3] + num3.ToString();
                                    result = num1 * (float)num2 / num3;
                                    break;
                            }
                            break;
                        case 4:
                            switch (optype2)
                            {
                                case 1:
                                    s = num1.ToString() + op[3] + num2.ToString() + op[0] + num3.ToString();
                                    result = (float)num1 / num2 + num3;
                                    break;
                                case 2:
                                    s = num1.ToString() + op[3] + num2.ToString() + op[1] + num3.ToString();
                                    result = (float)num1 / num2 - num3;
                                    break;
                                case 3:
                                    s = num1.ToString() + op[3] + num2.ToString() + op[2] + num3.ToString();
                                    result = (float)num1 / num2 * num3;
                                    break;
                                case 4:
                                    s = num1.ToString() + op[3] + num2.ToString() + op[3] + num3.ToString();
                                    result = (float)num1 / num2 / num3;
                                    break;
                            }
                            break;
                        
                    }
                if(numop==3)
                    switch (optype1)
                    {
                        case 1:
                            switch (optype2)
                            {
                                case 1:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[0] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 + num2 + num3+num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[0] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 + num2 + num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[0] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 + num2 + num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[0] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 + num2 + (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[1] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 + num2 - num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[1] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 + num2 - num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[1] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 + num2 - num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[1] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 + num2 - (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[2] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 + num2 * num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[2] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 + num2 * num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[2] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 + num2 * num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[2] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 + (float)num2 * num3 / num4;
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[3] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 + (float)num2 / num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[3] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 + (float)num2 / num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[3] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 + (float)num2 / num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[0] + num2.ToString() + op[3] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 + (float)num2 / num3 / num4;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 2:
                            switch (optype2)
                            {
                                case 1:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[0] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 - num2 + num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[0] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 - num2 + num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[0] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 - num2 + num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[0] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 - num2 + (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[1] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 - num2 - num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[1] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 - num2 - num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[1] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 - num2 - num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[1] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 - num2 - (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[2] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 - num2 * num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[2] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 - num2 * num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[2] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 - num2 * num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[2] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 - (float)num2 * num3 / num4;
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[3] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 - (float)num2 / num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[3] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 - (float)num2 / num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[3] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 - (float)num2 / num3 - num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[1] + num2.ToString() + op[3] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 - (float)num2 / num3 - num4;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 3:
                            switch (optype2)
                            {
                                case 1:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[0] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 * num2 + num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[0] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 * num2 + num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[0] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 * num2 + num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[0] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 * num2 + (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[1] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 * num2 - num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[1] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 * num2 - num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[1] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 * num2 - num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[1] + num3.ToString() + op[3] + num4.ToString();
                                            result = num1 * num2 - (float)num3 / num4;
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[2] + num3.ToString() + op[0] + num4.ToString();
                                            result = num1 * num2 * num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[2] + num3.ToString() + op[1] + num4.ToString();
                                            result = num1 * num2 * num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[2] + num3.ToString() + op[2] + num4.ToString();
                                            result = num1 * num2 * num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[2] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 * num2 * num3 / num4;
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[3] + num3.ToString() + op[0] + num4.ToString();
                                            result = (float)num1 * num2 / num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[3] + num3.ToString() + op[1] + num4.ToString();
                                            result = (float)num1 * num2 / num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[3] + num3.ToString() + op[2] + num4.ToString();
                                            result = (float)num1 * num2 / num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[2] + num2.ToString() + op[3] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 * num2 / num3 / num4;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case 4:
                            switch (optype2)
                            {
                                case 1:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[0] + num3.ToString() + op[0] + num4.ToString();
                                            result = (float)num1 / num2 + num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[0] + num3.ToString() + op[1] + num4.ToString();
                                            result = (float)num1 / num2 + num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[0] + num3.ToString() + op[2] + num4.ToString();
                                            result = (float)num1 / num2 + num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[0] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 / num2 + num3 / num4;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[1] + num3.ToString() + op[0] + num4.ToString();
                                            result = (float)num1 / num2 - num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[1] + num3.ToString() + op[1] + num4.ToString();
                                            result = (float)num1 / num2 - num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[1] + num3.ToString() + op[2] + num4.ToString();
                                            result = (float)num1 / num2 - num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[1] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 / num2 - num3 / num4;
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[2] + num3.ToString() + op[0] + num4.ToString();
                                            result = (float)num1 / num2 * num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[2] + num3.ToString() + op[1] + num4.ToString();
                                            result = (float)num1 / num2 * num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[2] + num3.ToString() + op[2] + num4.ToString();
                                            result = (float)num1 / num2 * num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[2] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 / num2 * num3 / num4;
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (optype3)
                                    {
                                        case 1:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[3] + num3.ToString() + op[0] + num4.ToString();
                                            result = (float)num1 / num2 / num3 + num4;
                                            break;
                                        case 2:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[3] + num3.ToString() + op[1] + num4.ToString();
                                            result = (float)num1 / num2 / num3 - num4;
                                            break;
                                        case 3:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[3] + num3.ToString() + op[2] + num4.ToString();
                                            result = (float)num1 / num2 / num3 * num4;
                                            break;
                                        case 4:
                                            s = num1.ToString() + op[3] + num2.ToString() + op[3] + num3.ToString() + op[3] + num4.ToString();
                                            result = (float)num1 / num2 / num3 / num4;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                if ((result - (int)result) != 0)
                {
                    i--;
                    continue;
                }
                ti[i] = s;
                ti[n+i] = s+"="+result.ToString();

            }

            return ti;
        }
    }
}
