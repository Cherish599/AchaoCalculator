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
    public class ConnectTests
    {
        [TestMethod()]
        public void randomIntTest()
        {
            //创建一个Connect类型的对象
            Connect con = new Connect();
            //定义一个变量来接收产生的这个随机数
            int number = con.randomInt(1, 100);
            //如果产生的这个随机数在[1,100)则测试通过
            bool result = (number >= 1 && number < 100);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void randomopTest()
        {
            //创建一个Connect类型的对象
            Connect con = new Connect();
            //定义一个字符变量来接收随机产生的这个运算符
            string op = con.randomop();
            //如果产生的这个随机运算符是运算符中的一个，则测试通过
            bool result = (op == "+" || op == "-" || op == "*" || op == "/");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void createExpressionTest()
        {
            //创建一个Connect类型的对象
            Connect con = new Connect();
            List<string> conlist = new List<string>();
            //声明一个表示运算符个数的变量
            int count = 3;
            //如果这个conlist不为空，则证明通过测试
            conlist = con.createExpression(count);
            Assert.IsNotNull(conlist);
        }
    }
}