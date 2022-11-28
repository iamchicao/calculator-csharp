namespace CalculatorCsharp.Bll
{
    internal class Basic
    {
        public decimal Number1;
        public decimal Number2;
        public Dictionary<int, string> MathOperations = new Dictionary<int, string>() 
        {
            {1, "Addition"},
            {2, "Subtraction"},
            {3, "Multiplication"},
            {4, "Division"},
        };

        public Basic(decimal number1, decimal number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
    }
}
