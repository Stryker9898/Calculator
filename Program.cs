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

            string template = $"{firstNumber} {operation} {secondNumber} =";
            decimal result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "%" => firstNumber % secondNumber,
                _ => 0
            };
            System.Console.WriteLine(result);
        }
    }
}