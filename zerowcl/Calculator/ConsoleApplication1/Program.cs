using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入题目数量：");
            int n = Convert.ToInt32(Console.ReadLine());//读取数字
            Console.WriteLine("题目为：");
            Build b1 = new Build(n);//生成算式
            Console.Read();
        }
    }
    public  class Build
    {
        public Build(int n)
        {
            run1(n);
            Console.WriteLine(run1(n));
            run2(run1(n));
        }
        public struct data//结构体
        {
            public int x, y, z;//分别代表3个运算数
            public int a1, a2;//分别代表2个运算符
            public int sum;//代表运算结果
        }
        public static char choice1(int a)//选择运算符号
        {
            if (a == 1)
                return '+';
            else if (a == 2)
                return '-';
            else if (a == 3)
                return '*';
            else
                return '/';
        }
        public static int choice2(int x, int y, int z)//运算过程，这里x，z表示运算数字，y表示运算符号
        {
            if (y == 1)
                return x + z;
            else if (y == 2)
                return x - z;
            else if (y == 3)
                return x * z;
            else if (y == 4 && z > 0)
                return x / z;
            else
                return x + z;
        }
        public static int Sum(int x,int y,int z,int a1,int a2 )//运算优先级选择
        {
            if (a1 <= 2 || a2 > 2)
                return choice2(x, a1, choice2(y, a2, z));
            else
                return choice2(choice2(x, a1, y), a2, z);
        }
        public bool judge(List<data> data, data k)//判断算式是否符合要求
        {
            for (int i = 0; i < data.Count; i++)//判断是否重复
                if (data[i].x == k.x && data[i].y == k.y && data[i].z == k.z && data[i].a1 == k.a1 && data[i].a2 == k.a2)
                    return false;

            if ((Sum(k.x,k.y,k.z,k.a1,k.a2) % 1) != 0)//判断是否为小数
                return false;
            if (Sum(k.x, k.y, k.z, k.a1, k.a2) < 0)//判断是否为负数
                return false;
            return true;
        }
        public string run1(int n)//随机生成算式
        {
            string strList = "";
            List<data> data = new List<data>();
            for (int i = 0; i < n; i++)
            {
                Random r = new Random();
                while (true)
                {
                    data m = new data();
                    m.x = r.Next(1, 101);
                    m.a1 = r.Next(1, 5);
                    m.y = r.Next(1, 101);
                    m.a2 = r.Next(1, 5);
                    m.z = r.Next(1, 101);
                    if (judge(data, m))
                    {
                        m.sum = Sum(m.x, m.y, m.z, m.a1, m.a2);
                        data.Add(m);
                        break;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                strList = strList + data[i].x + "" + choice1(data[i].a1) + "" + data[i].y + "" 
                    + choice1(data[i].a2) + "" + data[i].z + "=" + data[i].sum + "\n";
            }
            return strList;
        }
        public void run2(string msg)//打印到txt文件
        {
            string path = @"D:\随机四则运算.txt";
            System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
            sw.WriteLine(msg);
            sw.Flush();
            sw.Close();
        }
    }
}

