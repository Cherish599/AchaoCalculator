using System;
using Xunit;
using progress2;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        // ���Դ���ʱ���������ʧ��Print()����û�п��Ƿ���ֵ��
        //���Բ���ʱʹ��debugģʽ���޸���Ӧ�������ڽ��ж���
        public void Test1()
        {
            string fomula = "1+4/2";
            Problem p = new progress2.Problem(1);
            p.Print();
            Assert.Equal(1 + 4 / 2, 3 );
           
        }
    }
}
