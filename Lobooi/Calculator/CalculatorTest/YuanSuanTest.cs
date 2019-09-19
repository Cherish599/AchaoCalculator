using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class YuanSuanTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 11, 46, 23, 48, 92, };//测试题目数
            int[] b = { 122, 530, 462, 799, 1500};//测试计算数范围

            SiZeYuanSuan YStest;//引用测试对象
            //测试循环
            for (int i = 0; i < 5; i++)
            {
                YStest = new SiZeYuanSuan(a[i],b[i]);
                if (YStest.Result.Length == a[i]) { Console.WriteLine("通过！"); }
                else Console.WriteLine("不通过！");
            }

        }
    }
}
