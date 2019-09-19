using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class CreateTests
    {
        [TestMethod()]
        public void AnswerTest()
        {
            Create c = new Create();
            string s = "20*12/10";
            string result = "24";
            string re = c.Answer(s);
            Assert.AreEqual(result, re);
        }
        [TestMethod()]
        public void CheckTest()
        {
            Create c = new Create();
            string s = "2+78/0";
            int s_re = 2;
            string s2 = "13.4";
            string s3 = "2+7*1";
            int s1_re = 1;
            string s4 = "213";
            int r1 = c.Check(s, s2);
            Assert.AreEqual(r1, s_re);
            int r2 = c.Check(s3, s4);
            Assert.AreEqual(r2, s1_re);
        }
        [TestMethod()]
        public void TitleTest()
        {
            Create c = new Create();
            c.Title(7);
        }
    }
}