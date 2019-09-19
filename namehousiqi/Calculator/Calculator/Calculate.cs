using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Calculator
{
    public class Calculate
    {

        Random random = new Random(Guid.NewGuid().GetHashCode());
        List<string> list = new List<string>();
         public void makeExercises(int n)
        {
            list.Clear();
            int i;
            for (i = 0; i < n; i++)
            {
                if (!getOneTest())//生成一个列表
                {
                    i--;
                    continue;
                }
            }
            writeToFile();
        }

        private bool getOneTest()
        {
            String str = "";
            int result = 0;
            int[] x = new int[4];
            int [] c = new int[4];
            int t = random.Next(3, 5);//随机生成3-4个数字
            int i,j;
            Stack<int> xs = new Stack<int>();//数字栈
            Stack<int> cs = new Stack<int>();//字符栈
            for (i = 0; i < t; i++)
            {
                x[i] = random.Next(0,101);
                c[i] = random.Next(0, 4);
            }
       
            str += x[0]; 
            for(i = 0;i<t-1;i++)
            {
                switch (c[i])
                {
                    case 0:
                        str += " + ";
                        break;
                    case 1:
                        str += " - ";
                        break;
                    case 2: 
                        str += " * ";
                        break;
                    case 3:
                        str += " ÷ ";
                        break;
                    default:  break;
                }
                str += x[i+1];     
            }
            xs.Push(x[0]);
            i = 0;//遍历运算符
            j = 1;//遍历数字
            int temp;
            while (j<t&&i<t-1)
            {
                if (c[i] < 2)//加法或减法时
                {
                    if (c[i] == 1)//减法时
                    {
                        cs.Push(0);
                        xs.Push(0 - x[j++]);
                        i++;
                    }
                    else
                    {
                        cs.Push(c[i++]);
                        xs.Push(x[j++]);
                    }
                    
                }
                else
                {
                    if (c[i++] == 2)//乘法时
                    {
                        temp = xs.Pop() * x[j++];
                    }
                    else//除法时
                    {
                        if (x[j] == 0)//被除数为0
                        {
                            return false;
                        }
                        if (xs.Peek() % x[j] != 0)//结果为小数
                        {
                            return false;
                        }
                        temp = xs.Pop() / x[j++];
                        
                    }
                    xs.Push(temp);
                }
            }
            while (cs.Count > 0)
            {
                if (cs.Pop() == 0)
                {
                    result = xs.Pop() + xs.Pop();
                }
                else
                {
                    result = 0 - (xs.Pop() - xs.Pop());
                }
                xs.Push(result);
            }
            result = xs.Pop();
            if (result < 0)
                return false;
            str += " = " + result;
            list.Add(str);
            return true;
        }
        private void writeToFile()
        {

            try
            {
                FileStream file = new FileStream("subject.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.Default);
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine(list.ElementAt(i));
                    Console.WriteLine(list.ElementAt(i));
                }

                writer.Close();
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("文件写入错误!");
                Console.WriteLine(e.Message);
            }
     
        }
    }
    
}


