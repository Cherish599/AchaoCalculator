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
    public class ProgramTests
    {
        [TestMethod()]
        public void SuijiyunsuanTest()
        {
            string a=Program.Random_opration();
            Assert.IsNotNull(a);//判断是否产生了随机式结果
        }
    }
}