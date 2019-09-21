using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zg_cal
{
    class Stack
    {
        char[] arr;
        int size;
        int top;

        public Stack()
        {
            this.size = 3;
            top = -1;
            this.arr = new char[size];
        }

        public char pop()
        {
            return arr[top--];
        }
        
        public void push(char ch)
        {
            arr[++top] = ch;
        }

        public Boolean isEmpty()
        {
            return top == -1;
        }
    }
}
