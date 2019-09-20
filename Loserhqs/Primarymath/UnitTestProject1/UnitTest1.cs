using System;
using Primarymath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            //TestMethod1();
            //TestMethod2();
            //TestMethod3();
            //TestMethod4();
            TestMethod5();
        }
        public void TestMethod1()
        {
            //测试随机数
            int testnum = Rand.rand.Next(0, 100);
            int testopr = Rand.rand.Next(0, 4);
            int testtype = Rand.rand.Next(0, 2);
            Console.WriteLine(testnum);
            Console.WriteLine(Produce.oper[testopr]);
            if (testtype == 0)
            {
                Console.WriteLine("三个数的运算");
            }
            else
            {
                Console.WriteLine("四个数的运算");
            }
        }
        //测试两个数的运算
        public void TestMethod2()
        {
            //testA=8*9
            double ResultA = 72;
            double TestA = Linkup.arith(8, 9, 2);
            if (ResultA == TestA)
            {
                Console.WriteLine("testA的测试结果正确");
            }
            else
            {
                Console.WriteLine("testA的测试结果错误");
            }
            //testB=20/40
            double ResultB = 0.5;
            double TestB = Linkup.arith(20, 40, 3);
            if (ResultB == TestB)
            {
                Console.WriteLine("testB的测试结果正确");
            }
            else
            {
                Console.WriteLine("testB的测试结果错误");
            }
            //testC=56/8
            double ResultC = 7;
            double TestC = Linkup.arith(56, 8, 3);
            if (ResultB == TestB)
            {
                Console.WriteLine("testC的测试结果正确");
            }
            else
            {
                Console.WriteLine("testC的测试结果错误");
            }
        }
        //测试结果是否为整数
        public void TestMethod3()
        {
            double testnum1 = 5.63;
            double testnum2 = 45;
            if(Linkup.nonnegint(testnum1))
            {
                Console.WriteLine("testnum1测试正确");
            }
            else
            {
                Console.WriteLine("testnum1测试错误");
            }
            if (Linkup.nonnegint(testnum2))
            {
                Console.WriteLine("testnum2测试正确");
            }
            else
            {
                Console.WriteLine("testnum2测试错误");
            }
        }
        //测试运算函数
        public void TestMethod4()
        {
            //三个数的运算
            //testop1=78-5*9
            //int resultop1 = 33;
            Console.WriteLine("预测结果为33");
            Console.WriteLine("真实结果如下：");
            int flag1 = Opterator.optwo(78, 5, 9, 1, 2, Produce.oper);
            if(flag1==1)
            {
                Console.WriteLine("结果正确");
            }
            else
            {
                Console.WriteLine("结果错误");
            }
            //testop2=23+12/4
            //int resultop2 = 26;
            Console.WriteLine("预测结果为26");
            Console.WriteLine("真实结果如下：");
            int flag2 = Opterator.optwo(23, 12, 4, 0, 3, Produce.oper);
            if (flag2 == 1)
            {
                Console.WriteLine("结果正确");
            }
            else
            {
                Console.WriteLine("结果错误");
            }
            //四个数的运算
            //testop3=5*9-42/7
            //int resultop3 = 39;
            Console.WriteLine("预测结果为26");
            Console.WriteLine("真实结果如下：");
            int flag3 = Opterator.opthree(5, 9, 42, 7, 2,1,3 ,Produce.oper);
            if (flag3 == 1)
            {
                Console.WriteLine("结果正确");
            }
            else
            {
                Console.WriteLine("结果错误");
            }
            //testop4=5-9+77/11
            //int resultop4 = 11;
            Console.WriteLine("预测结果为11");
            Console.WriteLine("真实结果如下：");
            int flag4 = Opterator.opthree(5, 9, 77, 11, 1, 0, 3, Produce.oper);
            if (flag4 == 1)
            {
                Console.WriteLine("结果正确");
            }
            else
            {
                Console.WriteLine("结果错误");
            }
        }
        //测试能否生成相应数量的题目
        public void TestMethod5()
        {
            int n = 5;
            Produce.produce(n);
        }
    }
}
