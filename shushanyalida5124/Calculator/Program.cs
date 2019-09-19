using System;
using System.IO;
using System.Data;

namespace Calculator
{
    public class Program
    {
        public static string path = @"E:\Subjects.txt";
        static void Main(string[] args)
        {
            int n;
            StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("请输入练习题数量：");
            n =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("已将以下算式写入{0}:",path);
            for (int i = 0; i < n; i++)
            {
                System.Threading.Thread.Sleep(200);
                string sub = Get_A_Subject();
                sw.WriteLine(sub);
                Console.WriteLine(sub);
            }
            sw.Close();
        }

        //生成一个不等式
        static public string Get_A_Subject()
        {
            DataTable dt = new DataTable();
            Random rdm = new Random();
            int[] num = new int[4];
            num[0] = rdm.Next(101);
            char[] ch = new char[3];
            string subject =  num[0].ToString();      //代表算式的字符串
            int cnum = rdm.Next(2, 4);                //运算符个数
            num[cnum] = rdm.Next(101);  
            string subjectTest = num[0].ToString();   //用于检验算式的结果是否为整数

            for (int m = 0; m < cnum; m++)
            {
                num[m] = rdm.Next(101);

                int r = rdm.Next(4);
                switch (r)
                {
                    case 0:
                        ch[m] = '+'; break;
                    case 1:
                        ch[m] = '-'; break;
                    case 2:
                        ch[m] = '*'; break;
                    case 3:
                        ch[m] = '/'; break;
                    default:
                        break;
                }

                //排除除数为零的算式
                if (ch[m] == '/' && num[m] == 0) 
                {
                    m--;
                    continue;
                }

                subjectTest = subject + ch[m] + num[m];

                //排除结果非整数的算式
                if (Convert.ToDouble(dt.Compute(subjectTest, "")) != Convert.ToDouble(Convert.ToInt64(Convert.ToDouble(dt.Compute(subjectTest, "")))))
                {
                    m--;
                    continue;
                }

                subject = subject+ ch[m] + num[m];
            }
            subject = subject + "=" + dt.Compute(subject, "");
            return subject;
        }
    }
}
    