using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要完成的题目数量：");
            string input = Console.ReadLine(); //控制台输入一个整数
            int nn = Convert.ToInt32(input); //将输入转换成整数 
            //int nn =1000000;//构造的式子的数量
            MyCal cal = new MyCal();
            cal.create(nn);
        }
    }
    public class MyCal
    {
        public void create(int nn)
        {
            Random r = new Random();
            int[] a = new int[2];
            int i;//用于for循环

            DataTable dt = new DataTable();//用于运算
            while (nn > 0)
            {
                for (i = 0; i <= 1; i++)
                {
                    a[i] = r.Next(2, 4);//决定生成多少个符号
                }

                int sign = a[1];
                int num = sign + 1;
                int[] bnum = new int[num];//存储随机生成的数字
                String[] snum = new String[num];//数字转成字符串

                int[] c = new int[sign];//存储随机生成的符号，1代表+，2代表-，3代表x，4代表/
                char[] dsign = new char[sign];

                for (i = 0; i < num; i++)//生成数字
                {
                    bnum[i] = r.Next(1, 100);
                    snum[i] = Convert.ToString(bnum[i]);
                }
                for (i = 0; i < sign; i++)//生成符号
                {
                    c[i] = r.Next(1, 5);
                    switch (c[i])
                    {
                        case 1:
                            dsign[i] = '+';
                            break;
                        case 2:
                            dsign[i] = '-';
                            break;
                        case 3:
                            dsign[i] = '*';
                            break;
                        case 4:
                            dsign[i] = '/';
                            break;
                        default:
                            break;

                    }
                }
                String app = "";
                for (i = 0; i < sign; i++)//sign
                {
                    app = app + snum[i];
                    app = app + dsign[i];
                }
                app = app + snum[sign];


                String sb = app + "=" + dt.Compute(app, "");
                String result = calculate(app);
                //String result = Convert.ToString(dt.Compute(app, ""));

                if (result.Contains(".") || result.Contains("-"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(sb);
                    storeTest(sb);
                    nn--;
                }
            }
        }

        public String calculate(String app)
        {
            DataTable dt = new DataTable();
            String result = Convert.ToString(dt.Compute(app, ""));
            //Console.WriteLine(result);
            return result;
        }
        public void storeTest(String sb)
        {
            String path = "e:/subject.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(sb);
            sw.Close();
            fs.Close();
        }
    }
}
