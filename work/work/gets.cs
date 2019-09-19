using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    public class gets
    {
        Stack<string> stack = new Stack<string>();
        public void Gets1(List<string> vs)
        {
            stack.Clear();

            for (int i = vs.Count()-1; i >=0; i--)
            {
                int temp;
                if (choose.Choose(vs[i]).Equals(1))
                {
                    temp = Convert.ToInt32(stack.Pop());
                    temp *= Convert.ToInt32(vs[i - 1]);
                    stack.Push(Convert.ToString(temp));
                    i -= 1;
                }
                else if (choose.Choose(vs[i]).Equals(2))
                {
                    temp = Convert.ToInt32(stack.Pop());
                    if (Convert.ToInt32(vs[i - 1]) % temp == 0)
                    {

                        stack.Push(Convert.ToString(Convert.ToInt32(vs[i - 1])/temp));
                        i -= 1;
                    }
                    else
                    {
                        stack.Push("-1");
                        break;
                    }
                }
                else
                {
                    stack.Push(vs[i]);
                }
            }
        }
        public int Gets2()
        {
            Stack<string> st = this.stack;
            int temp1;
            if (st.Contains("-1"))
            {
                return -1;
            }
            else
            {
                while(st.Count()>=1)
                {
                    if(st.Count()==1)
                    {
                        return Convert.ToInt32(st.Pop());
                    }
                    temp1 = Convert.ToInt32(st.Pop());
                    if(choose.Choose(st.Pop()).Equals(3))
                    {
                        temp1 += Convert.ToInt32(st.Pop());
                        st.Push(Convert.ToString(temp1));
                    }
                    else
                    {
                        temp1 -= Convert.ToInt32(st.Pop());
                        st.Push(Convert.ToString(temp1));
                    }
                }
                return Convert.ToInt32(st.Pop());
            }
        }
    }
}
