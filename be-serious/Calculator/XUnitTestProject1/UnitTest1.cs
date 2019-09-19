using Xunit;
using Calculator;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int ret = Calculator.Program.Solve("1+2+3*4/2");
            Assert.Equal(9, ret);
        }
    }
}
