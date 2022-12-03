namespace CalculatorCsharp.Bll
{
  //Scientific calculator inherits the methods of the basic calculator
  internal class Scientific : Basic
  {
    //Declare variables
    public double Angle;
    public int Exponential;
    public double NumberBase;

    /*
    Scientific calculator calls the basic calculator constructor
    Before that, the method Open is invoked, bringing the dictionary for the operations and the result of operation choosed
    */
    public Scientific() : base()
    {
      Open();
    }

    public override void Open()
    {
      Dictionary<int, string> scientificOperations = new Dictionary<int, string>()
      {
          {5, "Exponentiation"},
          {6, "Square root"},
          {7, "Sine"},
          {8, "Cosine"},
          {9, "Tangent"}
      };

      foreach (KeyValuePair<int, string> i in scientificOperations)
      {
        MathOperations.Add(i.Key, i.Value);
      }

      foreach (KeyValuePair<int, string> mathOperation in MathOperations)
      {
        Console.WriteLine($"{mathOperation.Key} - {mathOperation.Value}");
      }

      int operation;
      //Run while the user does not enter a valid number(1 to 9) and 0 to exit
      do
      {
        Console.WriteLine("\nWhich operation do you want realize?");
        operation = Convert.ToInt32(Console.ReadLine());

        if (operation == 0)
        { 
          Console.WriteLine("Calculator closed!!");
          return;
        }
      } while (operation < 1 || operation > 9);

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
      else if (operation == 5)
      {
        Console.WriteLine("\nEnter the number base: ");
        NumberBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the exponential number: ");
        Exponential = Convert.ToInt32(Console.ReadLine());

        Exponentiation();
      }
      else if (operation == 6)
      {
        Console.WriteLine("\nEnter the number: ");
        Number1 = Convert.ToDouble(Console.ReadLine());

        SquareRoot();
      }
      else
      {
        Console.WriteLine("\nEnter the angle: ");
        Angle = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
          case 7:
            Sin();
            break;
          case 8:
            Cos();
            break;
          case 9:
            Tangent();
            break;
        }
      }

      Console.WriteLine("\nThe result of operatios is " + Result.ToString("0.##"));
      Console.WriteLine($"Enter any key to close");
    }

    //method to calculate the exponentiation
    public void Exponentiation()
    {
      Result = Math.Pow(NumberBase, Exponential);
    }

    //method to calculate the square root
    public void SquareRoot()
    {
      Result = Math.Sqrt(Number1);
    }

    //method to calculate the sine
    public void Sin()
    {
      Result = Math.Sin(Angle);
    }

    //method to calculate the cosine
    public void Cos()
    {
      Result = Math.Cos(Angle);
    }

    //method to calculate the tangent
    public void Tangent()
    {
      Result = Math.Tan(Angle);
    }
  }
}
