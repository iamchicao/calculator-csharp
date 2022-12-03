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
            {0, "Close"},
            {1, "Addition"},
            {2, "Subtraction"},
            {3, "Multiplication"},
            {4, "Division"},
        };

    //Constructors for Polymorphism treatment:

    //public Constructor of double type
    public Basic(double number1, double number2)
    {
      Number1 = number1;
      Number2 = number2;

      Open();
    }

    //public Constructor of integer type
    public Basic(int number1, int number2)
    {
      Number1 = Convert.ToDouble(number1);
      Number2 = Convert.ToDouble(number2);

      Open();
    }

    //public Constructor of number and integer type
    public Basic(double number1, int number2)
    {
      Number1 = number1;
      Number2 = Convert.ToDouble(number2);

      Open();
    }

    //public Constructor of integer and double type
    public Basic(int number1, double number2)
    {
      Number1 = Convert.ToDouble(number1);
      Number2 = number2;

      Open();
    }

    public Basic() { }

    /*
    Method to open the calculator: print the menu, according to the dictionary using switch case
    Print the result of operation
    */
    public virtual void Open()
    {
      foreach (KeyValuePair<int, string> operation in MathOperations)
      {
        Console.WriteLine($"{operation.Key} - {operation.Value}");
      }

      int data;
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

      Console.WriteLine("\nThe result of operatios is " + Result.ToString("0.##"));
      Console.WriteLine($"Enter any key to close");
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
