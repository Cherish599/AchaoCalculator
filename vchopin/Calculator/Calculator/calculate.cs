using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class calculate
    {
        int n;
        List<line> lines ;
        internal List<line> Lines { get => lines; set => lines = value; }

        public calculate(int n)
        {
            this.n = n;
            lines = new List<line>();
        }


        public void generateNum()
        {
            char[] chars = new char[] { '+', '-', '×', '÷' };
            for (int i = 0; i < n; i++)
            {
                line linet;

                if (random.Random3or4() == 0)
                {
                    linet = new line3();
                    linet.Num1 = random.RandomNum();
                    linet.Num2 = random.RandomNum();
                    linet.Num3 = random.RandomNum();
                    linet.Op1 = chars[random.RandomOp()];
                    linet.Op2 = chars[random.RandomOp()];


                    while (linet.Op1 == linet.Op2)//保证符号不一致
                    {
                        linet.Op2 = chars[random.RandomOp()];
                    }

                    if (linet.Op1 == '÷')//判断除法为整数
                    {
                        int tempNum2 = linet.Num2;
                        JudgeDiv(linet.Num1, ref tempNum2);
                        linet.Num2 = tempNum2;
                    }

                    if (linet.Op2 == '÷')//判断除法为整数
                    {
                        int tempNum3 = linet.Num3;
                        JudgeDiv(linet.Num2, ref tempNum3);
                        linet.Num3 = tempNum3;
                    }

                    if (linet.Op1 == '-')
                    {
                        int num2 = linet.Num2;
                        int num3 = linet.Num3;
                        JudggSub(linet.Num1, ref num2, ref num3, linet.Op2,true);
                        linet.Num2 = num2;
                        linet.Num3 = num3;
                    }
                    if (linet.Op2 == '-')
                    {
                        int num2 = linet.Num2;
                        int num1 = linet.Num1;
                        JudggSub(linet.Num3, ref num1, ref num2, linet.Op1, false);
                        linet.Num2 = num2;
                        linet.Num1 = num1;
                    }
                }
                else
                {
                    linet = new line4();
                    linet.Num1 = random.RandomNum();
                    linet.Num2 = random.RandomNum();
                    linet.Num3 = random.RandomNum();
                    linet.Num4 = random.RandomNum();
                    linet.Op1 = chars[random.RandomOp()];
                    linet.Op2 = chars[random.RandomOp()];
                    linet.Op3 = chars[random.RandomOp()];

                    while (linet.Op1 == linet.Op2 || linet.Op2 == linet.Op3)//保证符号不一致
                    {
                        linet.Op2 = chars[random.RandomOp()];
                    }

                    

                    if (linet.Op1 == '÷')//判断除法为整数
                    {
                        int tempNum2 = linet.Num2;
                        JudgeDiv(linet.Num1, ref tempNum2);
                        linet.Num2 = tempNum2;
                        
                    }

                    if (linet.Op2 == '÷')//判断除法为整数
                    {
                        int tempNum3= linet.Num3;
                        JudgeDiv(linet.Num2, ref tempNum3);
                        linet.Num3 = tempNum3;
                    }

                    if (linet.Op3 == '÷')//判断除法为整数
                    {
                        int tempNum4 = linet.Num4;
                        JudgeDiv(linet.Num3, ref tempNum4);
                        linet.Num4 = tempNum4;
                    }


                    if (linet.Op1 == '-')//判断相减不是负数
                    {

                        if (linet.Op3 == '-')//判断两边是减号情况
                        {
                            int tempSum = 0;
                            do
                            {
                                tempSum = choiceCal(linet.Op2, linet.Num2, linet.Num3);

                                if ((linet.Num1 - linet.Num4) < 0)
                                    linet.Num1 = random.RandomNum(linet.Num4,101);
                                if (tempSum <= (linet.Num1-linet.Num4))
                                    break;

                                linet.Num2 = random.RandomNum(1,(linet.Num1 - linet.Num4)/4+1);
                                linet.Num3 = random.RandomNum(1,(linet.Num1 - linet.Num4)/4+1);

                            } while (true);
                        }
                        else
                        {
                            int tempSum = 0;

                            if (linet.Op2 == '+')//第二个是加号就判断第二个数就行
                            {
                                while (linet.Num2 >= linet.Num1)
                                    linet.Num2 = random.RandomNum();
                            }
                            if (linet.Op2 == '×' || linet.Op2=='÷')//不是加号 ，求出结果
                            {
                                tempSum = choiceCal(linet.Op2, linet.Num2, linet.Num3);

                                if (linet.Op3 == '×' || linet.Op3 == '÷')
                                {
    
                                    tempSum = choiceCal(linet.Op3, tempSum, linet.Num4);

                                    while (tempSum > linet.Num1)//重新分配值
                                    {
                                        linet.Num2 = random.RandomNum(1, linet.Num1 / 8+1);
                                        linet.Num3 = random.RandomNum(1, linet.Num1 / 8+1);
                                        linet.Num4 = random.RandomNum(1, linet.Num1 / 8+1);

                                        if (linet.Op2 == '÷')
                                        {

                                            int tempNum3 = linet.Num3;
                                            JudgeDiv(linet.Num2, ref tempNum3);
                                            linet.Num3 = tempNum3;
                                        }
                                        if (linet.Op3 == '÷')
                                        {
                                            int tempNum4 = linet.Num4;
                                            JudgeDiv(linet.Num3, ref tempNum4);
                                            linet.Num4 = tempNum4;
                                        }

                                        tempSum = choiceCal(linet.Op2, linet.Num2, linet.Num3);
                                        
                                    }
                                }
                                else//加号情况
                                {

                                    while (tempSum > linet.Num1 + linet.Num4)
                                    {
                                        linet.Num2 = random.RandomNum(1, linet.Num1 / 4);
                                        linet.Num3 = random.RandomNum(1, linet.Num1 / 4);

                                        tempSum = choiceCal(linet.Op2, linet.Num2, linet.Num3);
 
                                    }
                                        
                                }

                            }
                        }
                    }
                    if (linet.Op2 == '-')
                    {
                        //直接判断减号两边的情况
                        int tempSum1 = 0;
                        int tempSum2 = 0;

                        do
                        {
                            tempSum1 = choiceCal(linet.Op1, linet.Num1, linet.Num2);
                            tempSum2 = choiceCal(linet.Op3, linet.Num3, linet.Num4);

                            if (tempSum2 < tempSum1)
                                break;
                            linet.Num1 = random.RandomNum(50,100);
                            linet.Num2 = random.RandomNum(50,100);
                            linet.Num3 = random.RandomNum(0, 50);
                            linet.Num4 = random.RandomNum(0, 50);
                            linet.Op1 = chars[random.RandomOp()];
                            if (linet.Op1 == '÷')//判断除法为整数
                            {
                                while (linet.Num1 % linet.Num2 != 0)
                                {
                                    linet.Num2 = random.RandomNum(linet.Num1/2);
                                }
                            }

                        } while (true);  
                    }
                    if (linet.Op3 == '-')
                    {
                        //判断前面的比最后一个数大
                        int tempSum = 0;
                        tempSum = choiceCal(linet.Op1, linet.Num1, linet.Num2);
                        tempSum = choiceCal(linet.Op2, tempSum, linet.Num3);
                        do
                        {

                            if (tempSum > linet.Num4)
                                break;

                            linet.Num4 = random.RandomNum();

                        } while (true);
                    }

                }

                Console.WriteLine(linet);
                lines.Add(linet);


            }
        }

        /*
        * Comments : 混合四则运算规则
        * Param char op : 操作符号
        * Param int num1 : 第一个操作数
        * Param int num2 : 第二个操作数
        * Author : vchopin
        * @Return int
        */
        private int choiceCal(char op, int num1, int num2)
        {
            int tempSum = 0;
            switch (op)
            {
                case '+': tempSum = num1 + num2; break;
                case '-': tempSum = num1 - num2; break;
                case '×': tempSum = num1 * num2; break;
                case '÷': tempSum = num1 / num2; break;
            }
            return tempSum;
        }

        /*
       * Comments : 能否除尽
       * Param int num1 : 被除数
       * Param int num2 : 除数
       * Author : vchopin
       * @Return void
       */
        private void JudgeDiv(int num1,ref int num2)
        {

            while (num1 % num2 != 0)
            {
                num2 = random.RandomDiv(num1);
            }
        }

        /*
       * Comments : 是否为负数
       * Param char op1 : 操作符号
       * Param int num1 : 第一个操作数
       * Param int num2 : 第二个操作数
       * Param int num2 : 第三个操作数
       * Param char op1 : 操作符号
       * Param bool choice : 选择是大于还是小于
       * Author : vchopin
       * @Return int
       */
        private void JudggSub(int num1, ref int num2, ref int num3, char op1,bool choice)
        {
            int tempSum = 0;
            do
            {
                tempSum = choiceCal(op1, num2, num3);
                if (choice)
                {
                    if (tempSum < num1)
                        break;
                }
                else
                {
                    if (tempSum > num1)
                        break;
                }

                num2 = random.RandomNum();
                num3 = random.RandomNum();
                if (op1 == '÷')
                {
                    while (num2 % num3 != 0)
                    {
                        num3 = random.RandomNum(1,num2 / 2+1);
                    }
                }
                    
            } while (true);
        }
        
    }
}
