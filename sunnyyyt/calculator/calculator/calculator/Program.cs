using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
             Console.WriteLine("请输入运算题的数量:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(Calculate(MakeFormula()));
            }
            Console.ReadLine();
        }
        public static string MakeFormula()
        {
            int number1,number2,number3,number4;
            int opCount;
            int opNumber;
            string result = null;
            Random random = new Random();
            number1 = (int)random.Next(0, 101);
            number2= (int)random.Next(0, 101);
            number3= (int)random.Next(0, 101);
            number4= (int)random.Next(0, 101);
            int[] num = { number1, number2, number3,number4 };
            string[] Ope = { "+", "-", "*", "/" };
            opCount = (int)random.Next(2, 4);
            result += number1;
            for (int i = 0; i < opCount; i++)
            {
             
                opNumber = (int)random.Next(0, 4);
                result = result + Operator(opNumber) + num[i+1];
            }
            return result;
        }
        public static string Operator(int n)
        {
            string[] Ope = { "+", "-", "*", "/" };

          
            if (n == 0)
            {
                return Ope[0];
            }
            else if (n == 1)
            {
                return Ope[1];
            }
            else if (n == 2)
            {
                return Ope[2];
            }
            else
            {
                return Ope[3];
            }
        }
        public static string Calculate(string result)
        {
           
            DataTable dt = new DataTable();
            object obj = null;
            obj = dt.Compute(result, "");
            while(obj.ToString().Contains(".")||result.Contains
                ("/0"))
            {
                result = MakeFormula();
                obj = dt.Compute(result, "");
            }
            return result + "=" + obj.ToString();

        }
    }
   

}
