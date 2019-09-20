using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class makenumberTest
    {
        [TestMethod()]
        public void makeNumberTest()
        {
            maker mymaker = new maker();
            for (int i = 0; i < 20; i++)
            {
                int y = mymaker.makeSign();
                int x = mymaker.makeNumber(y);
                if (y == 103 && x == 0)
                {
                    Console.WriteLine("出错");
                    Console.WriteLine(x + " " + y);
                    return;
                }

            }
            Console.WriteLine("没有运行错误");
            //Assert.Fail();
        }

        [TestMethod()]
        public void getResultTest()
        {
            maker mymaker = new maker();
            List<int> signs = new List<int>();
            List<int> numbers = new List<int>();
            
            signs.Add(100);
            signs.Add(101);
            numbers.Add(10);
            numbers.Add(10);
            numbers.Add(10);
            //上述题目为10+10-10
            Assert.AreNotEqual(10, mymaker.getResult(signs, numbers));
            signs.Clear();
            numbers.Clear();
            signs.Add(103);
            signs.Add(102);
            numbers.Add(10);
            numbers.Add(6);
            numbers.Add(10);
            //上述题目为10/6*10，因为是小数，所以抛出异常数-1000000
            Assert.AreNotEqual(-1000000, mymaker.getResult(signs, numbers));
            //Assert.Fail();
        }

        [TestMethod()]
        public void makequiTest()
        {
            
            //Assert.Fail();
        }
    }
}