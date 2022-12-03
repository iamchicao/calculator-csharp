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
    Before that, the method Open is invoked, bringing the dictionary for the operations
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

      foreach (KeyValuePair<int, string> operation in MathOperations)
      {
        Console.WriteLine($"{operation.Key} - {operation.Value}");
      }

      int data;

      //Run while the user does not enter a valid number(1 to 9) and 0 to exit
      do
      {
        Console.WriteLine("\nWhich operation do you want realize?");
        data = Convert.ToInt32(Console.ReadLine());

        if (data == 0)
        { 
          Console.WriteLine("Calculator closed!!");
          return;
        }
      } while (data < 1 || data > 9);

      //If the user enters a number between 1 and 4, the basic calculator is called
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
      else if (data == 5)
      {
        Console.WriteLine("\nEnter the number base: ");
        NumberBase = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nEnter the exponential number: ");
        Exponential = Convert.ToInt32(Console.ReadLine());

        Exponentiation();
      }
      else if (data == 6)
      {
        Console.WriteLine("\nEnter the number: ");
        Number1 = Convert.ToDouble(Console.ReadLine());

        SquareRoot();
      }
      else
      {
        Console.WriteLine("\nEnter the angle: ");
        Angle = Convert.ToDouble(Console.ReadLine());

        switch (data)
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

    public void Exponentiation()
    {
      Result = Math.Pow(NumberBase, Exponential);
    }

    public void SquareRoot()
    {
      Result = Math.Sqrt(Number1);
    }

    public void Sin()
    {
      Result = Math.Sin(Angle);
    }

    public void Cos()
    {
      Result = Math.Cos(Angle);
    }

    public void Tangent()
    {
      Result = Math.Tan(Angle);
    }
  }
}
