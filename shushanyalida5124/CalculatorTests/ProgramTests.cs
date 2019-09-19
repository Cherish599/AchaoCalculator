using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Get_A_SubjectTest()
        {   
            
            string sTest = Program.Get_A_Subject();
            string[] sTestArry = sTest.Split('=');
            string sLeft = sTestArry[0];  //等式左边
            string sRight = sTestArry[1]; //等式右边
            Assert.IsFalse((sLeft is null) || (sRight is null));  
        }
    }
}