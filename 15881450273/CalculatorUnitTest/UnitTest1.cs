using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorUnitTest;
using calculation;
using System.Windows.Forms;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            //先测试三个符号等式是否正常
            calculation.Makefour makefour = new Makefour();
            String[] suanshi = new String[10000];
            suanshi = makefour.fun4(3);
            MessageBox.Show(suanshi[0] + Environment.NewLine + suanshi[1] + Environment.NewLine + suanshi[2] + Environment.NewLine);
            }
        [TestMethod]
        public void TestMethod2()
        {
            //先测试两个符号等式是否正常
            calculation.Makequality make = new Makequality();
            String[] suanshi2 = new String[10000];
            suanshi2 = make.fun3(3);
            MessageBox.Show(suanshi2[0] + Environment.NewLine + suanshi2[1] + Environment.NewLine + suanshi2[2] + Environment.NewLine);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //测试产生整个四则运算的工厂是是否正常
            calculation.From1 sh  = new From1();
            sh.Show();
           
        }
    }

   

}









  

