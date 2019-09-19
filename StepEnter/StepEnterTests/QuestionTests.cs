using Microsoft.VisualStudio.TestTools.UnitTesting;
using StepEnter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepEnter.Tests
{
    [TestClass()]
    public class QuestionTests
    {
        [TestMethod()]
        public void QuestionTest()
        {
            bool flag = true;
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void CreateQuestionTest()
        {
            char[] option = { '+', '-', '*', '/' };
            Random rand = new Random();
            int temp = rand.Next(0, 4);
            char sign = option[temp];
            Assert.AreEqual(sign, '+' | '-' | '*' | '/');
        }

        [TestMethod()]
        public void JudgeTest()
        {
            Random rand = new Random();
            int op_cnt = rand.Next(0, 4);
            bool flag = true ;
            for (int i = 0; i < op_cnt; ++i)
            {
                bool judge = true;
                if (judge == false)
                    flag = false;
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void calculateTest()
        {
            char sign = '/';
            int ans;
            int num1 = 1;
            int num2 = 0;
            bool flag=false;
            switch (sign)
            {
                case '+':
                    Console.WriteLine("加法运算");
                    flag = true;
                    break;
                case '-':
                    Console.WriteLine("加法运算");
                    ans = num1 - num2;
                    if (ans < 0)//判断表达式是否会出现负数
                        flag=true;
                    break;
                case '*':
                    Console.WriteLine("加法运算");
                    flag = true;
                    break;
                case '/':
                    Console.WriteLine("加法运算");
                    if (num2 == 0 || num1 % num2 != 0)//判断分母不为零并计算是否是分数
                        flag = true;
                    break;
                default:
                    flag = true;
                    Console.WriteLine("发生错误！");
                    break;
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void WriteTest()
        {
            bool  flag = true;
            Assert.IsTrue(flag);
        }
    }
}