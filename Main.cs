using CalculatorCsharp.Bll;

namespace CalculatorCsharp
{
    internal class Main
    {
        public static void Start()
        {
            //declare variables and intialize
            int calculator;
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            //var number1 = "";
            //var number2 = "";

            //Print the menu for the user to choose the calculator
            Console.WriteLine("CALCULATORS");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1) Basic");
            Console.WriteLine("2) Scientific");
            Console.WriteLine("3) Financial");
            Console.WriteLine("--------------------------");

            //If the user enters a value other than 1, 2 or 3, the program will ask to enter again
            do
            {
                Console.WriteLine("Which calculator do you want to use? (1, 2 or 3)");
                calculator = Convert.ToInt32(Console.ReadLine());

            } while (calculator <= 0 || calculator > 3);


            //If the user enters 1, the program will ask for the numbers and call the basic calculator
            if (calculator == 1)
            {
                //Convert the string to double, because console.readline returns a string
                Console.WriteLine("\nEnter the first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                number2 = Console.ReadLine();
            }

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
                default:
                    Console.WriteLine("Invalid number of calculator!");
                    break;
            }
                 
        }
    }
}
