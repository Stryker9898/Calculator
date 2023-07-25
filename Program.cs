using System;
namespace Calculator
{

    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Enter values ");
            System.Console.WriteLine("First number ");
            string firstUserValue = Console.ReadLine();
            System.Console.WriteLine("Second number ");
            string secondUserValue = Console.ReadLine();
            System.Console.WriteLine("Operations [+, -, *, /, % ]");
            string operation = Console.ReadLine();

            System.Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserValue); 
            decimal secondNumber = Convert.ToDecimal(secondUserValue);

            System.Console.WriteLine("Calculating results:");
            switch (operation)
            {
                case "+":
                    System.Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber + secondNumber}");
                    break;
                case "-":
                    System.Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber - secondNumber}");
                    break;
                case "*":
                    System.Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber * secondNumber}");
                    break;
                case "/":
                    System.Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber / secondNumber}");
                    break;
                case "%":
                    System.Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber % secondNumber}");
                    break;
                default:
                    System.Console.WriteLine("Unknown operation");
                    break;
            }

            System.Console.WriteLine("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 18 && userAge < 28)
            { System.Console.WriteLine("You are eligible to military service"); }

            else
            { System.Console.WriteLine("You are not eligible to military service"); }
        }
    }
}