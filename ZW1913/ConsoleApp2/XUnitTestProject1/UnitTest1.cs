using System;
using Xunit;
using _Random;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            new _Random.mathvoid().mathjian();
            Assert.Equal(1, 1);
        }
    }
}
