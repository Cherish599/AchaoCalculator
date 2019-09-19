using System;
using System.Collections.Generic;
using System.IO;
using System.Text;     

namespace Calculator {
    public class Program {
        public static void Main(string[] args) {
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 1000000;//进行一百万次运算
            int operatorNum;
            int i, j;
            double result;
            string opera = "+-*/";
            StringBuilder[] exercise = new StringBuilder[n];

            for (i = 0; i < n; i++) {
                StringBuilder sb = new StringBuilder();
                Random rd = new Random(Guid.NewGuid().GetHashCode());
                operatorNum = rd.Next(2, 4);//运算符个数

                for (j = 0; j < operatorNum; j++) {
                    sb.Append(rd.Next(0, 101));
                    sb.Append(opera[rd.Next(0, 4)]);
                }
                sb.Append(rd.Next(0, 101));

                //check dividend 0
                if (sb.ToString().Contains("/0")) {
                    i--;
                    continue;
                }

                //get result and check decimals
                Compute cm = new Compute(sb);
                cm.DoTrans();
                result = cm.Calculate();
                if (result.ToString().Contains(".") || result<0) {
                    i--;
                    continue;
                }
                sb.Append('=');
                sb.Append(result);

                exercise[i] = sb;
            }

            foreach (var m in exercise) {
                string path = @"C:\Users\hasee\Desktop\博客\MyCalculator\AchaoCalculator\1.txt";
                FileInfo fileInfo = new FileInfo(path);
                StreamWriter sw = fileInfo.AppendText();
                sw.WriteLine(m);
                sw.Flush();
                sw.Close();
                Console.WriteLine(m);
            }
            Console.ReadKey();
        }
    }
}
