namespace Calculator
{
    public class Executioner : Evaluate
    {
        private Evaluate evaluate;
        public Executioner(string opt)
        {
            switch (opt)
            {
                case "+": this.evaluate = new Add(); break;
                case "-": this.evaluate = new Sub(); break;
                case "×": this.evaluate = new Mul(); break;
                case "÷": this.evaluate = new Div(); break;
            }
        }
        public string Calc(string num1, string num2)
        {
            return this.evaluate.Calc(num1, num2);
        }
    }
}
