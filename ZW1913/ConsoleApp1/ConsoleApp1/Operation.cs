using System;

namespace ConsoleApp1
{
    public class Operation
    {
        private  double m_NumberRight = 0;
        public double NumberRight
        {
            get => m_NumberRight;
            set => m_NumberRight = value;
        }
        private double m_NumberLeft = 0;
        public double NumberLeft
        {
            get { return m_NumberLeft; }
            set { m_NumberLeft = value; }
        }
        public virtual double getResult()
        {
            double result = 0;
            return result;
        }

        static void Main(string[] args)
        {
          
        }
    }
    public static Operation CreatOperation(string operate)
    {

    }
}
