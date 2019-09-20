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
    public class jisuanTests
    {
        [TestMethod()]
        public void resultTest()
        {
            jisuan J = new jisuan();
            string s1 = "13-9+25*2";
            string correct = "54";
            string now = J.result(s1);
            Assert.AreEqual(correct, now);
        }

        [TestMethod()]
        public void SybxTest()
        {
            jisuan J = new jisuan();
            int numb = 1;
            string op = "+";
            string now = J.Sybx(numb);
            Assert.AreEqual(op, now);
        }

        [TestMethod()]
        public void setequalTest()
        {
         
            int b1 = 0;
            string h = null;
            jisuan J = new jisuan();
            h = J.setequal();
            foreach (char c in h)
            {
                if (char.IsDigit(c)) //是否为数字 如数字计数器加1;
                {
                    b1++;
                }
            }
         
        }
    }
}