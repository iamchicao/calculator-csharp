using CalculatorCsharp.Bll;

namespace CalculatorCsharp
{
  internal class Main
  {
    public static void Start()
    {
      //declare variables and intialize
      int calculator;
      var number1 = 0.0; 
      var number2 = 0.0; 

      //Print the menu for the user to choose the calculator
      Console.WriteLine("CALCULATORS");
      Console.WriteLine("--------------------------");
      Console.WriteLine("1) Basic");
      Console.WriteLine("2) Scientific");
      Console.WriteLine("3) Financial");
      Console.WriteLine("--------------------------");

      //User choose which calculator he wants to use, if he enters a value other than 1, 2 or 3, the program will ask to enter again
      do
      {
        Console.WriteLine("Which calculator do you want to use? (1, 2 or 3)");
        calculator = Convert.ToInt32(Console.ReadLine());
      } while (calculator <= 0 || calculator > 3);


      //If the user enters 1, the program will ask for the numbers and call the basic calculator
      if (calculator == 1)
      {
        //Treatment to convert the string to double or int
        Console.WriteLine("\nEnter the first number: ");
        var aux = Console.ReadLine(); //return string
        if (aux!.Contains(",") || aux.Contains("."))
        {
          number1 = Convert.ToDouble(aux);
        }
        else
        {
          number1 = Convert.ToInt32(aux);
        }

        Console.WriteLine("Enter the second number: ");
        var aux2 = Console.ReadLine();
        if (aux2!.Contains(",") || aux2.Contains("."))
        {
          number2 = Convert.ToDouble(aux2);
        }
        else
        {
          number2 = Convert.ToInt32(aux2);
        }
      }
      Console.WriteLine(" ");

      //Switch to choose the calculator, and then call the method to open the calculator
      switch (calculator)
      {
        case 1:
          new Basic(number1, number2);
          break;
        case 2:
          new Scientific();
          break;
        case 3:
          new Financial();
          break;
      }
    }
  }
}
