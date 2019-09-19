using Microsoft.VisualStudio.TestTools.UnitTesting;
using test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Tests
{
    [TestClass()]
    public class GetCalTests
    {
      
        [TestMethod()]
        public void GetCalculationTest()
        {
            GetCal cal = new GetCal();
            Random rd = new Random();
            string Cal = cal.GetCalculation(rd);
            Assert.IsTrue(Cal != null);
        }
    }
}

namespace CalculatorTests
{
    class GetCalTests
    {
    }
}
