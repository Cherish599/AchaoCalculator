using System;
using Xunit;
using DaoLayer;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           int num =  new DaoLayer.StudentDAO().getStudentRecordsNums();
            Assert.Equal(84, num);
        }
    }
}
