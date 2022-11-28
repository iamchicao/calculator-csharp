using System;

public class Calculator {
  static void Main() {
    Console.WriteLine($"{Sum(5, 5)}");
    Console.WriteLine($"{Subtraction(15, 10)}");
    Console.WriteLine($"{Multiplication(5, 5)}");
    Console.WriteLine($"{Division(25, 5)}");
  }
  
  static float Sum(float number1, float number2)
  {
    return number1 + number2;
  }
  static float Subtraction(float number1, float number2)
  {
    return number1 - number2;
  }

  static float Multiplication(float number1, float number2)
  {
    return number1 * number2;
  }

  static float Division(float number1, float number2)
  {
    return number1 / number2;
  }
}