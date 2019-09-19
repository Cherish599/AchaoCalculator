using System;
using Xunit;
using ConsoleApp2;
namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = "1+2+3*4/2";
            float f = ConsoleApp2.Program.CalcByDataTable(s);
            Assert.Equal(9 + "", f + "");
        }
    }
}