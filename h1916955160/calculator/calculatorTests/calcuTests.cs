using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Tests
{
    [TestClass()]
    public class calcuTests
    {
        [TestMethod()]
        public void calcuTest()
        {
            int[] testayy_a = new int[] { 10, 15, 20 };
            char[] testarr_b = new char[] { '+', '/' };
            calcu cal_tor = new calcu(testayy_a, testarr_b);
            if(!cal_tor.calaclate1())
            {
                Console.WriteLine("结果有小数，不予输出");
            }
            int sum = cal_tor.calculate2();
            if (5 == sum)
                Console.WriteLine("结果正确");
            else
                Console.WriteLine("结果错误");
            //Assert.Fail();
        }
    }
}