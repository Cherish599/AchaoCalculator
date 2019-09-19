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
    public class ProgramTests
    {
        [TestMethod()]
        public void createTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void FuHaoTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void CountTest()
        {
            string str1 = "1+50/2";
            string str2 = "78+82+60/3";
            string str3 = "1+57*2";
            int ans1 = 26;
            int ans2 = 180;
            int ans3 = 115;
            Assert.AreEqual(Program.Count(str1),ans1);
            Assert.AreEqual(Program.Count(str2), ans2);
            Assert.AreEqual(Program.Count(str3), ans3);
        }

        [TestMethod()]
        public void MainTest()
        {
           // Assert.Fail();
        }
    }
}