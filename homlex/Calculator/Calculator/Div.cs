namespace Calculator
{
    public class Div : Evaluate
    {
        public string Calc(string num1, string num2)
        {
            return (int.Parse(num1) / int.Parse(num2)).ToString();
        }
    }
}
