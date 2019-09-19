using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator01.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            //Assert.Fail();
        }

        //对生成随机数函数测试
        [TestMethod()]
        public void randomTest()
        {
            /*传入给random()函数的两组参数，完全不同，
            那么生成的随机数randomNum和randomNum2值应该不同*/
            int randomNum = Program.random(1, 3);
            int randomNum2 = Program.random(5, 10);
            Assert.AreNotEqual(randomNum, randomNum2);

            /*传给random()函数的参数分别为10,20，那么
             * 生成的随机数应满足：10<=randomNum3<20
             */
            int randdomNum3 = Program.random(10, 20);
            Assert.AreNotEqual(randdomNum3, 21);

            int x = Program.random(1, 10);
            int y = Program.random(1, 10);
            Assert.AreNotEqual(x, y);
            for(int i=0;i<19;i++)
            {
                Console.WriteLine(Program.random(0, 100));
            }
            //Assert.Fail();
        }

        //对计算四则运算式结果函数测试
        [TestMethod()]
        public void countingResultTest()
        {
            /*传给countingResult()函数的算式为"8+12*3"
            *那么计算结果应为"44"
            */
            string result = Program.countingResult("8+12*3");
            string reallyData = "44";
            Assert.AreEqual(result, reallyData);
            //Assert.Fail();
        }

        //对生成四则运算式函数测试
        [TestMethod()]
        public void produceEquationTest()
        {
            //Assert.Fail();
            //随机生成的两个四则运算式应不相同
            string equation = Program.produceEquation();
            string equation2 = Program.produceEquation();
            Assert.AreNotSame(equation, equation2);
        }

        //对检查四则运算式结果的函数测试
        [TestMethod()]
        public void checkTest()
        {
            //当字符串中含有"."或者"-",check()返回false
            //否则check()返回true
            string stringTest = "-13224.423";
            string stringTest2 = "-123";
            string stringTest3 = "131.00";
            string stringTest4 = "134";
            Assert.IsFalse(Program.check(stringTest));
            Assert.IsFalse(Program.check(stringTest2));
            Assert.IsFalse(Program.check(stringTest3));
            Assert.IsTrue(Program.check(stringTest4));

            //Assert.Fail();
        }
    }
}