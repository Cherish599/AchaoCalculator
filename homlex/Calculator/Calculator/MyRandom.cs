using System;

namespace Calculator
{
    public class MyRandom
    {
        public static string GetRandomOpt()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int index = random.Next(1,1000) % 4;
            return "+-×÷"[index].ToString();
        }

        public static string GetRandomNum(int minValue, int maxValue)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(minValue, maxValue).ToString();
        }
    }
}
