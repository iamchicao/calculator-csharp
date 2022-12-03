namespace CalculatorCsharp.Bll
{
  //Financial calculator inherits the methods of the basic calculator
  internal class Financial : Basic
  {
    public double InitialValue;
    public double InterestRate;
    public int Period;

    /*
    Financial calculator calls the basic calculator constructor
    Before that, the method Open is invoked, bringing the dictionary for the operations and the result of operation choosed
    */
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

      foreach (KeyValuePair<int, string> i in financialOperations) //add financialOperations to MathOperations
      {
        MathOperations.Add(i.Key, i.Value);
      }

      foreach (KeyValuePair<int, string> mathOperation in MathOperations)
      {
        Console.WriteLine($"{mathOperation.Key} - {mathOperation.Value}");
      }

      int operation;

      //Run while the user does not enter a valid number(1 to 6) and 0 to exit
      do
      {
        Console.WriteLine("\nWhich operation do you want realize?");
        operation = Convert.ToInt32(Console.ReadLine());

        if (operation == 0) 
        {
          Console.WriteLine("Calculator closed!!");
          return;
        }
      } while (operation < 1 || operation > 6);

      //opens the method of each operation:
      if (operation == 1 || operation == 2 || operation == 3 || operation == 4)
      {
        Console.WriteLine("\nEnter the first number: ");
        Number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the second number: ");
        Number2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
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

        switch (operation)
        {
          case 5:
            SimpleInterest();
            break;
          case 6:
            CompoundInterest();
            break;
        }
      }

      if (operation == 1 || operation == 2 || operation == 3 || operation == 4)
      {
          Console.WriteLine("\nThe result of operatios is " + Result.ToString("0.##"));
      }
      Console.WriteLine($"Enter any key to close");
    }

    //Method to calculate the simple interest
    public void SimpleInterest()
    {
      Result = InitialValue * (InterestRate / 100) * Period;
      Console.WriteLine("\nSimple Interest is " + Result.ToString("0.##"));
      Console.WriteLine("Total to pay is " + (Result + InitialValue).ToString("0.##"));
    }

    //Method to calculate the compound interest
    public void CompoundInterest()
    {
      Result = InitialValue * Math.Pow((1 + (InterestRate / 100)), Period);
      Console.WriteLine("\nCompound Interest is " + Result.ToString("0.##"));
      Console.WriteLine("Total to pay is " + (Result + InitialValue).ToString("0.##"));
    }
  }
}
