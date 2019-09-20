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
    public class EquationTests
    {
        [TestMethod()]
        public void creatEquationTest()
        {
            //针对除数为0的测试
            Assert.IsFalse(Equation.creatEquation().Contains("0"));
        }
    }
}