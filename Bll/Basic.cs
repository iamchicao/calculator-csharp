namespace CalculatorCsharp.Bll
{
    internal class Basic
    {
        //Declare public variables kind of float
        public double Number1;
        public double Number2;
        public double Result;

        //Dicionary: key and value, in this case, the key is the number of operation and the value is the name of operation
        public Dictionary<int, string> MathOperations = new Dictionary<int, string>() 
        {
            {1, "Addition"},
            {2, "Subtraction"},
            {3, "Multiplication"},
            {4, "Division"},
        };

        //public Contructor of double type
        public Basic(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }
        //public Contructor of double integer
        public Basic(int number1, int number2)
        {
            Number1 = Convert.ToDouble(number1);
            Number2 = Convert.ToDouble(number2);
        }

        /*
        Ainda precisamos desse outro conntructor?
        Ou isso é a chamada de inicalização do objeto conforme os parâmetros passados?
        */
        public Basic() {}

        /*
        Method to open the calculator: print the menu, according to the dictionary using switch case
        Print the result of operation
        */
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

        //Method to sum two numbers
        public void Addition()
        {
            Result = Number1 + Number2;
        }
        
        //Method to subtract two numbers
        public void Subtraction()
        {
            Result = Number1 - Number2;
        }

        //Method to multiply two numbers
        public void Multiplication()
        {
            Result = Number1 * Number2;
        }

        //Method to divide two numbers
        public void Division()
        {
            Result = Number1 / Number2;
        }
    }
}
