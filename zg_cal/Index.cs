using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class Index
    {
        
        GetNumbers g_nums = new GetNumbers();
        GetOp g_op = new GetOp();

        
        
        public Index()
        {

        }

        public String question()
        {
            Stack_nums s_nums = new Stack_nums();// stack of nums
            Stack s_op = new Stack();//stack of op

            String s_ques = "";

            int nums_op = Only.r.Next(2, 4);//the number of operators;
            String op = g_op.getOp(nums_op);//String of operators

            int number = g_nums.getNumbers();
            s_nums.push(number);//入栈
            s_ques += number;
            for (int i = 0; i< nums_op; i++)
            {
                number = g_nums.getNumbers();
                s_nums.push(number);//入栈
                String s_num = "";
                s_num += number;
                
                while (i<nums_op)
                {
                    s_ques += op[i];
                    s_ques += s_num;
                    if (op[i] == '*' || op[i] == '/')
                    {
                        double a = s_nums.pop();
                        double b = s_nums.pop();

                        if (op[i] == '*')
                            s_nums.push(a * b);
                        else if (a != 0)
                            s_nums.push(b / a);
                        else
                            return "wrong!";
                        
                    }
                    else
                        s_op.push(op[i]);
                    break;
                }
            }

            while (!s_op.isEmpty())
            {
                char cal_op = s_op.pop();
                double a = s_nums.pop();
                double b = s_nums.pop();
                if(cal_op=='+')
                    s_nums.push(a + b);
                else
                    s_nums.push(b - a);
            }
            double anw = s_nums.pop();
            return (anw >= 0 && anw - (int)anw == 0) == true ? s_ques + " = "+(int)anw : "wrong!";
        }
            
    }
}
