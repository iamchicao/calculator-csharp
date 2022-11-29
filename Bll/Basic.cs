namespace CalculatorCsharp.Bll
{
    internal class Basic
    {
        public double Number1;
        public double Number2;
        public double Result;

        public Dictionary<int, string> MathOperations = new Dictionary<int, string>() 
        {
            {1, "Addition"},
            {2, "Subtraction"},
            {3, "Multiplication"},
            {4, "Division"},
        };

        public Basic(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public Basic() {}

        public virtual void Open()
        {
            foreach(KeyValuePair<int, string> operation in MathOperations)
            {
                Console.WriteLine($"{operation.Key} - {operation.Value}");
            }

            Console.WriteLine("\nWhich operation do you want realize?");
            var data = Convert.ToInt32(Console.ReadLine());

            switch (data)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
            }
            Console.WriteLine($"Result = {Result}");
        }

        public void Addition()
        {
            Result = Number1 + Number2;
        }
        
        public void Subtraction()
        {
            Result = Number1 - Number2;
        }

        public void Multiplication()
        {
            Result = Number1 * Number2;
        }

        public void Division()
        {
            Result = Number1 / Number2;
        }
    }
}
