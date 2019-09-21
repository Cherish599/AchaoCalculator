using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class Stack_nums
    {
        double[] arr;
        int size;
        int top;

        public Stack_nums()
        {
            size = 4;
            arr = new double[size];
            top = -1;
        }

        public void push(double num)
        {
            arr[++top] = num;
        }

        public double pop()
        {
            return arr[top--];
        }
    }
}
