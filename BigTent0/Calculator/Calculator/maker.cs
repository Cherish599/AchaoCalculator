using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*算法描述
*先由随机数得到运算符的个数，存入到一个列表中
*根据得到符号的个数，得到运算数的个数，用随机数生产并存入列表中
*将得到的数和符号依次入栈，如果遇到乘号和除号就出栈一个和下一个数运算
* 并得出结果，然后入栈。最后得到的就只有加减运算。按次序计算便可得出结果
* 最后将数字符号和结果按次序打印出来
* 为了符号好入栈，所以加减乘除都用数字代替 依次是100 101 102 103
* 
* 
*/
namespace Calculator
{
   public class maker
    {
        //产生随机数
        Random random = new Random();
        
        
        //产生随机符号
        public int makeSign()
        {
            int sign=100;
            int choseFlag;
            choseFlag = random.Next(1, 5);
            switch(choseFlag)//用数字代表符号
            {
                case 1:
                    sign = 100;//加法
                    break;
                case 2:
                    sign = 101;//减法
                    break;
                case 3:
                    sign = 102;//乘法
                    break;
                case 4:
                    sign = 103;//除法
                    break;
            }
            return sign;
        }

        public int makeNumber(int sign)
        {//根据产生的符号产生随机数。如果上一个符号为/号，则不能产生0
            int number=0;
            if(sign==103)
            {
                number = random.Next(1, 100);
            }
            else
                number = random.Next(0, 100);
            return number;
        }

        public float getResult(List<int> sign, List<int> number)
        {//根据产生的符号和数字计算出结果

            int[] items = new int[10];
            int top = 0;
            float result;
            items[0] = number[0];

            for(int i=0;i<sign.Count;i++)
            {
                if (sign[i] == 102 || sign[i] == 103) 
                {
                    if(sign[i]==102)
                    {
                        items[top] *= number[i + 1];
                    }
                    else
                    {
                        double temp = (double)items[top] / (double)number[i + 1] * 1.0;
                        items[top] /= number[i + 1];
                        
                        if(temp-items[top]>0)
                        {
                            return -1000000;
                        }
                    }
                }
                else
                {
                    items[++top] = sign[i];
                    items[++top] = number[i + 1];
                }
            }

            int k = top;
            result = items[0];
            if (top == 0)
            {
                return result;
                
            }
            else
            {
                for (int i = 1; i < top+1 ; i += 2)
                {
                    if (items[i] == 100)
                    {
                        result += items[i + 1];
                    }
                    if (items[i] == 101)
                    {
                        result -= items[i + 1];
                    }
                }
            }
            return result;
            
        }


        //sum为运算符号个数
        public void makequi(int quistionNum)
        {//将产生的题目打印出来
            int k = 0;
            int num = random.Next(2, 4);
            List<int> signs = new List<int>();
            List<int> numbers = new List<int>();
            while (k <= quistionNum)
            {
                for (int i = 0; i < num; i++)
                {
                    signs.Add(makeSign());
                }
                numbers.Add(random.Next(0, 100));
                for (int i = 0; i < num; i++)
                {
                    numbers.Add(makeNumber(signs[i]));
                }
                float result = getResult(signs, numbers);
                if(result!=-1000000)
                {
                    Console.Write(numbers[0]);
                    for (int i = 0; i < signs.Count; i++)
                    {

                        switch (signs[i])
                        {
                            case 100:
                                Console.Write("+");
                                break;
                            case 101:
                                Console.Write("-");
                                break;
                            case 102:
                                Console.Write("*");
                                break;
                            case 103:
                                Console.Write("/");
                                break;
                        }
                        Console.Write(numbers[i + 1]);
                    }
                    Console.Write("=" + result + "\n");
                    
                    k++;
                }
                signs.Clear();
                numbers.Clear();
            }
            
        }
    }
}
