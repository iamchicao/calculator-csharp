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
    Before that, the method Open is invoked, bringing the dictionary for the operations
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

      foreach (KeyValuePair<int, string> i in financialOperations)
      {
        MathOperations.Add(i.Key, i.Value);
      }

      foreach (KeyValuePair<int, string> operation in MathOperations)
      {
        Console.WriteLine($"{operation.Key} - {operation.Value}");
      }

      int data;

      //Run while the user does not enter a valid number(1 to 6) and 0 to exit
      do
      {
        Console.WriteLine("\nWhich operation do you want realize?");
        data = Convert.ToInt32(Console.ReadLine());

        if (data == 0) 
        {
          Console.WriteLine("Calculator closed!!");
          return;
        }
      } while (data < 1 || data > 6);

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

      if (data == 1 || data == 2 || data == 3 || data == 4)
      {
          Console.WriteLine("\nThe result of operatios is " + Result.ToString("0.##"));
      }
      Console.WriteLine($"Enter any key to close");
    }

    public void SimpleInterest()
    {
      Result = InitialValue * (InterestRate / 100) * Period;
      Console.WriteLine("\nSimple Interest is " + Result.ToString("0.##"));
      Console.WriteLine("Total to pay is " + (Result + InitialValue).ToString("0.##"));
    }

    public void CompoundInterest()
    {
      Result = InitialValue * Math.Pow((1 + (InterestRate / 100)), Period);
      Console.WriteLine("\nCompound Interest is " + Result.ToString("0.##"));
      Console.WriteLine("Total to pay is " + (Result + InitialValue).ToString("0.##"));
    }
  }
}
