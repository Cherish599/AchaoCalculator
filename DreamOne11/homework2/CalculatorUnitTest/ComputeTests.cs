using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2.Tests
{
    [TestClass()]
    public class ComputeTests
    {
        [TestMethod()]
        public void computeTest()
        {
            //针对计算结果的测试
            Assert.AreEqual(Compute.compute("10+11-15"),"10+11-15=6");
            Assert.AreEqual(Compute.compute("20*11/2"), "20*11/2=110");
            Assert.AreEqual(Compute.compute("5+10/2"), "5+10/2=10");
            Assert.AreEqual(Compute.compute("7-6/2"), "7-6/2=4");

            //针对计算过程不能为分数（小数）
            Assert.IsFalse(Compute.compute(Equation.creatEquation()).Contains("."));

            //针对计算过程不能为负数
            Assert.IsFalse(Compute.compute(Equation.creatEquation()).Contains("-"));
        }
    }
}