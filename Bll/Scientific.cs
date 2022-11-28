namespace CalculatorCsharp.Bll
{
    internal class Scientific : Basic
    {
        public Scientific(decimal number1, decimal number2) : base(number1, number2) 
        {
            Open();
        }

        public void Open()
        {
            Dictionary<int, string> map = new Dictionary<int, string>()
            {
                {5, "Exponentiation"},
                {6, "Square root"}
            };

            foreach(KeyValuePair<int, string> i in map)
            {
                MathOperations.Add(i.Key, i.Value);
            }

            foreach(KeyValuePair<int, string> operation in MathOperations)
            {
                Console.WriteLine($"{operation.Key} - {operation.Value}");
            }
        }
    }
}
