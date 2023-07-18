using System ;
namespace Calculator{

    class Program{
        static void Main()
        { 
            const float pi = 3.14f;
            System.Console.WriteLine("Enter values ");
            System.Console.WriteLine("First number ");
            string firstUserValue = Console.ReadLine();
            System.Console.WriteLine("Second number ");
            string secondUserValue = Console.ReadLine();
  
            System.Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);
              
            System.Console.WriteLine("Here are your results:");
            System.Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
            System.Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber-secondNumber}");
            System.Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber*secondNumber}");
            System.Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber/secondNumber}");
            System.Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber%secondNumber}");  
    }
}
}