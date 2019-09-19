using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.IO;

namespace Calculator01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("请输入你今天想做的题目个数：");
            //int totalNumber = int.Parse(Console.ReadLine());
            int totalNumber = 1000000;
            for (int i = 0; i < totalNumber; i++)
            {
                string str = produceEquation();
                Console.WriteLine(str + "=");
                string process = textOperartion(str + "=");
                string res = countingResult(str);
                string pro = textOperartion(res);
            }
        }
        //生成随机数种子
        public static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
        //生成lowerNumber-higherNumber区间的随机数（不包括higherNumber）
        public static int random(int lowerNumber, int higherNumber)
        {

            Random r = new Random(GetRandomSeed());
            int num = r.Next(lowerNumber, higherNumber);
            return num;
            
       }
        //生成算式
        public static string produceEquation()
        {
            string strResult = "";
            //字符串数组存放：+ - * /
            string[] operationGroups = { "+", "-", "*", "/" };
            //随机生成操作符个数
            int countOperations = random(2, 4);
            //用集合来存放算式中的操作数number,操作符operationGroup[index]
            ArrayList result = new ArrayList();
            for (int j = 0; j <= countOperations; j++)
            {
               
                int number = random(0, 101);
                result.Add(number);
                if (j < countOperations)
                {
                    int index = random(0, 4);
                    result.Add(operationGroups[index]);
                }
            }
            //类型转换
            for (int i = 0; i < result.Count; i++)
            {
                strResult += "" + result[i].ToString();
            }
            //检测生成的算式中是否有除零操作
            while (strResult.Contains("/0"))
            {
                strResult = produceEquation();
            }
            //检测运算过程中是否有负数以及运算结果是否含有小数
            string countinganswer = countingResult(strResult);
            if (false == check(countinganswer))
            {
                strResult = produceEquation();
            }
            return strResult;
        }

        //计算等式结果
        public static string countingResult(string strResult)
        {

            DataTable dt = new DataTable();
            string really_data = dt.Compute(strResult, " ").ToString();
            return really_data;
        }

        /*若生成的算式中计算过程中是否会有负数以及计算结果是否含有小数
          则返回false;否则返回true
        */
        public static Boolean check(string str)
        {
            Boolean flag = true;
            string res = countingResult(str);
            if (res.Contains(".") || res.Contains("-"))
            {
                flag = false;
            }
            return flag;
        }
        //将计算结果写入文件
        public static string textOperartion(string data)
        {
            //获取当前日期
            DateTime currentTime = DateTime.Now;
            string strYMD = currentTime.ToString("yyyyMMdd");
            //按照日期建立一个文件名
            string FileName = "MyFileSend" + strYMD + ".txt";
            //设置目录
            string CurDir = @"C:\Users\王慧\Desktop\AchaoCalculator\MyTextDir";
            //判断路径是否存在
            if (!Directory.Exists(CurDir))
            {
                Directory.CreateDirectory(CurDir);
            }
            //不存在就创建
            string FilePath = CurDir + FileName;
            //文件非覆盖方式添加内容
            StreamWriter file = new StreamWriter(FilePath, true);
            //保存数据到文件
            file.Write(data + "\r\n");
            //关闭文件
            file.Close();
            //释放对象
            file.Dispose();
            return FilePath;

        }

    }
}
