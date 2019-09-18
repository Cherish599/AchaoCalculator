using Microsoft.VisualStudio.TestTools.UnitTesting;
using REOCalculator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REOCalculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void CreateFormulaTest()
        {

            Assert.Fail();
        }
        [TestMethod()]
        public void calcTest()
        {
            Program p = new Program();
            string testStr = "10+20/2*5";
            string res = "60";
            string ans = p.calc(testStr);
            Assert.AreEqual(res, ans);
            //Assert.Fail();
        }

        [TestMethod()]
        public void writeTest()
        {
            string str = "This is a test File.";
            Program.write(str, "test1.txt");

            //StreamReader sr1 = new StreamReader("E:\\Software\\Calculator\\AyOhloop\\REOCalculator\\REOCalculatorTests\\obj\\Debug\\test2.txt");
            // StreamReader sr2 = new StreamReader("E:\\Software\\Calculator\\AyOhloop\\REOCalculator\\REOCalculatorTests\\obj\\Debug\\test1.txt");

            //Assert.AreEqual(sr1, sr2);
            //Assert.Fail();
            
        }

        [TestMethod()]
        public void MainTest()
        {
            Assert.Fail();
        }
    }
}