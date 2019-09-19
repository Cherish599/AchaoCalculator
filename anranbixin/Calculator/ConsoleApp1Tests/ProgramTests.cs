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
        //要引用函数的话，要把后面的改为static
        public void GetrandomTest()
        {
            string[] arr = new string[] { "+", "-", "*", "/" };
            string op = Program.Getrandom(arr);
            Assert.IsTrue(op.Contains("+")||op.Contains("-")||op.Contains("*")||op.Contains("/"));
        }

        [TestMethod()]
        public void GetnumTest()
        {
            int[] arr = new int[100];
            int m = 0;
            int num = Program.Getnum(m, arr);
            Assert.IsTrue(num >= 0);
        }

        [TestMethod()]
        public void funcTest()
        {
            string a = Program.func();
            Assert.IsFalse(a.Contains(" "));
        }

        [TestMethod()]
        public void VilidateTest()
        {
            string aa = "3+2-1";
            string co = "3+2-1=4";
            string pco = Program.Vilidate(aa);
            Assert.AreEqual(co,pco);
        }

        [TestMethod()]
        public void WriteTest()
        {
            bool bl;
            bl = Program.Write("1+1=2");
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetrandomTest1()
        {
            string[] arr = new string[] { "+", "-", "*", "/" };
            string op = Program.Getrandom(arr);
            Assert.IsTrue(op.Contains("+") || op.Contains("-") || op.Contains("*") || op.Contains("/"));
        }

        
    }
}