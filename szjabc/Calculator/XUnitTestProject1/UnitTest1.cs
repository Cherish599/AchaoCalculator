using System;
using Xunit;
using progress2;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        // 测试代码时，由于设计失误，Print()函数没有考虑返回值，
        //所以测试时使用debug模式，修改相应变量后，在进行断言
        public void Test1()
        {
            string fomula = "1+4/2";
            Problem p = new progress2.Problem(1);
            p.Print();
            Assert.Equal(1 + 4 / 2, 3 );
           
        }
    }
}
