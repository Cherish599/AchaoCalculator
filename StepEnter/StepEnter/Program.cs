using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StepEnter
{
    public class Question
    {
        public int question_num;//从用户端输入的问题个数
        public Random rand = new Random();//设置随机数
        public char[] option = { '+', '-', '*', '/' };//将四则运算符号放在option里
        public int[] arr = new int[4];//一个存放四则运算数字数组
        public char[] op = new char[3];//一个存放四册运算符号数组
        public Question() { }//构造函数
        public void CreateQuestion(int question_num)//创造question_num个四则运算
        {
            this.question_num = question_num;
            for (int i = 0; i < this.question_num;)
            {
                int op_cnt = rand.Next(2, 4);//从rand中选出2-3个符号，op_cnt即符号个数
                for (int j = 0; j < op_cnt; j++)
                {
                    arr[j] = rand.Next(0, 100);//从0-99中随机选出一个数放在arr[j]里
                    int temp = rand.Next(0, 4);//从0-3中取出一个数作为option的下标
                    op[j] = option[temp];//option[temp]里的符号存放在op[j]里
                }
                arr[op_cnt] = rand.Next(1, 100);//最后一个数（因为数字数始终比字符数大一个）
                if (Judge(op_cnt) == true)//判断这个表达式是否满足阿超的要求
                {
                    Write(op_cnt);//若满足要求，则打印表达式
                    i++;//若满足要求，继续下一个表达式
                }
            }
        }
        public bool Judge(int op_cnt)//判断这个表达式是否满足阿超的要求
        {
            for (int i = 0; i < op_cnt; ++i)
            {
                bool judge = calculate(arr[i], op[i], arr[i + 1]);
                if (judge == false)
                    return false;
            }
            return true;
        }
        public bool calculate(int num1, char op_1, int num2)//判断单个表达式是否满足要求
        {
            int ans;
            switch (op_1)
            {
                case '+':
                    ans = num1 + num2;
                    break;
                case '-':
                    ans = num1 - num2;
                    if (ans < 0)//判断表达式是否会出现负数
                        return false;
                    break;
                case '*':
                    ans = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0 || num1 % num2 != 0)//判断分母不为零并计算是否是分数
                        return false;
                    break;
                default:
                    Console.WriteLine("发生错误！");
                    break;
            }
            return true;
        }
        public void Write(int op_cnt)//打印表达式
        {
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < op_cnt; i++)
            {
                Console.Write(arr[i]);
                Console.Write(op[i]);
            }
            Console.WriteLine(arr[op_cnt]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Question question = new Question();
            question.CreateQuestion(n);
        }
    }
}
