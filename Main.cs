using CalculatorCsharp.Bll;

namespace CalculatorCsharp
{
    internal class Main
    {
        public static void Start()
        {
            int calculator;
            decimal number1;
            decimal number2;

            Console.WriteLine("CALCULATORS");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1) Basic");
            Console.WriteLine("2) Scientific");
            Console.WriteLine("3) Financial");
            Console.WriteLine("--------------------------");

            do
            {
                Console.WriteLine("Which calculator do you want to use? (1, 2 or 3)");
                calculator = Convert.ToInt32(Console.ReadLine());

            } while (calculator <= 0 || calculator > 3);

            Console.WriteLine("\nEnter the first number: ");
            number1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToDecimal(Console.ReadLine());

            switch (calculator)
            {
                case 1:
                    new Basic(number1, number2); //pode passar a expressão interia como parametro tbm
                    break;
                case 2:
                    new Scientific(number1, number2);
                    break;
                case 3:
                    new Financial(number1, number2);
                    break;
                default:
                    Console.WriteLine("Invalid number of calculator!");
                    break;
            }
                 
        }
    }
}
