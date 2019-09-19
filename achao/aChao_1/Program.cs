using System;
using System.Collections.Generic;
namespace aChao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Joint joint = new Joint();
            List<string> list = new List<string>();
            List<string> resultList = new List<string>();
            string temp = null;
            RandomCollection randomCollection = new RandomCollection();
            Unitl unitl = new Unitl();
            Console.WriteLine("请输入生成条数:");
            int n =Convert.ToInt32( Console.ReadLine());
            while (true)
            {
                if (n == 0)
                {
                    break;
                }
                list = joint.craeteEqual(randomCollection.randomInt(2, 4));
                temp = string.Join("", list.ToArray());
                Calculator calculator = new Calculator(list);
                int result = calculator.run();
                if (result != -1)
                {
                    resultList.Add(temp + "=" + result.ToString());
                    n--;
                }

            }
            unitl.writeTxt(resultList);
        }
    }
}
