using Microsoft.VisualStudio.TestTools.UnitTesting;
using arithmetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        [TestMethod()]
        public void calTest()
        {
            //创建一个Calculate类型的对象
            Calculate cal = new Calculate();
            //测试用例4+2*3
            List<string> calist = new List<string>();
            calist.Add("4");
            calist.Add("+");
            calist.Add("2");
            calist.Add("*");
            calist.Add("3");
            //此对象调用cal方法
            int result = cal.cal(calist);
            //若返回的值跟预期的结果10相同，则证明测试通过
            Assert.AreEqual(10,result);
        }
    }
}