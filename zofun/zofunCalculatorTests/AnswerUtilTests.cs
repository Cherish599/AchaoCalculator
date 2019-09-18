using Microsoft.VisualStudio.TestTools.UnitTesting;
using zofunCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zofunCalculator.Tests
{
    [TestClass()]
    public class AnswerUtilTests
    {
        [TestMethod()]
        public void calculateTest()
        {
            Assert.IsTrue((3 + 2 * 5)==(int)AnswerUtil.calculate("3+2*5"));
            Assert.IsTrue((3 + 2 - 5) == (int)AnswerUtil.calculate("3+2-5"));
            Assert.IsTrue((3 * 2 * 5) == (int)AnswerUtil.calculate("3*2*5"));
            Assert.IsTrue((3 + 6 / 2) == (int)AnswerUtil.calculate("3+6/2"));
            
            Assert.IsTrue((3 * 2 / 6) == (int)AnswerUtil.calculate("3*2/6"));
            Assert.IsTrue((3 * 2 + 6) == (int)AnswerUtil.calculate("3*2+6"));
            Assert.IsTrue((6 /2 / 3) == (int)AnswerUtil.calculate("6/2/3"));
          
        }
    }
}