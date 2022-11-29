namespace CalculatorCsharp.Bll
{
    internal class Financial : Basic
    {
        public double InitialValue;
        public double InterestRate;
        public int Period;

         public Financial() : base() 
         {
            Open();
         }

        public override void Open()
        {
            Dictionary<int, string> financialOperations = new Dictionary<int, string>()
            {
                {5, "Simple Interest"},
                {6, "Compound Interest"}
            };

            foreach (KeyValuePair<int, string> i in financialOperations)
            {
                MathOperations.Add(i.Key, i.Value);
            }

            foreach (KeyValuePair<int, string> operation in MathOperations)
            {
                Console.WriteLine($"{operation.Key} - {operation.Value}");
            }

            Console.WriteLine("\nWhich operation do you want realize?");
            var data = Convert.ToInt32(Console.ReadLine());

            if (data == 1 || data == 2 || data == 3 || data == 4) 
            {
                Console.WriteLine("\nEnter the first number: ");
                Number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter the second number: ");
                Number2 = Convert.ToDouble(Console.ReadLine());

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
            } 
            else
            {
                Console.WriteLine("\nEnter the initial value: ");
                InitialValue = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter the interest rate: ");
                InterestRate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter the period: ");
                Period = Convert.ToInt32(Console.ReadLine());

                switch (data)
                {
                    case 5:
                        SimpleInterest();
                        break;
                    case 6:
                        CompoundInterest();
                        break;
                }
            }

            Console.WriteLine($"Result = {Result}");
        }

        public void SimpleInterest()
        {
            Result = InitialValue + (InitialValue * Math.Pow(InterestRate/100, Period));
        }

        public void CompoundInterest()
        {
            Result = InitialValue * ((1 + (InterestRate/100))*Period);
        }
    }
}
