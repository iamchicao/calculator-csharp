using System;

public class Calculator {
  public float Number1;
  public float Number2;

  public Calculator(float number1, float number2) {
    Number1 = number1;
    Number2 = number2;

    Operations();
  }

  public void Operations()
  {
     Console.WriteLine($"{Sum(2, 3)}");
     Console.WriteLine($"{Subtraction(2, 3)}");
     Console.WriteLine($"{Multiplication(2, 3)}");
     Console.WriteLine($"{Division(2, 3)}");
  }

  public float Sum(float number1, float number2)
  {
    return number1 + number2;
  }
  
  public float Subtraction(float number1, float number2)
  {
    return number1 - number2;
  }

  public float Multiplication(float number1, float number2)
  {
    return number1 * number2;
  }

  public float Division(float number1, float number2)
  {
    return number1 / number;
  }
}

//Example
/* class Program {
    static void Main() {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Sum(2, 3));
    }
    
    static float Sum(float number1, float number2)
    {
      return number1 + number2;
    }
}
*/