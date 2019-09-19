using System;
using System.Collections.Generic;
using System.Text;

namespace Colotu
{
    public class method
    {
        public method()
        {

        }
        public int Resr(int x1)
        {
            Random c = new Random();

            int x2 = c.Next(1, 101);
            while ((x1 / x2) * x2 != x1)
                x2 = c.Next(1, 101);
            return x2;
        }
        public int Result(int[] x, int[] y, int d)
        {
            List<int> list = new List<int>();
            list.Add(x[0]);
            for (int i = 0; i < d; i++)
            {
                list.Add(y[i]);
                list.Add(x[i + 1]);

            }
            for (int i = 1; i < list.Count; i += 2)
            {
                //遍历时不需要类型转换
                if (list[i] == 3)
                {
                    list[i - 1] = list[i - 1] / list[i + 1];
                    list.RemoveRange(i, 2);
                    i = -1;
                }
                else if (list[i] == 2)
                {
                    list[i - 1] = list[i - 1] * list[i + 1];
                    list.RemoveRange(i, 2);
                    i = -1;
                }


            }
            for (int i = 1; i < list.Count; i += 2)
            {
                //遍历时不需要类型转换
                if (list[i] == 1)
                {
                    list[i - 1] = list[i - 1] - list[i + 1];
                    list.RemoveRange(i, 2);
                    i = -1;
                }
                else if (list[i] == 0)
                {
                    list[i - 1] = list[i - 1] + list[i + 1];
                    list.RemoveRange(i, 2);
                    i = -1;
                }

            }
            return list[0];
        }

    }
}
