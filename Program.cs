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

            if(firstNumber>secondNumber)
            {
                Console.WriteLine("First number is greater than second");
            }
            
            else if(firstNumber==secondNumber)
            
            {
                Console.WriteLine("First number is equal to second number");
            }
            
            else
            {
                Console.WriteLine("Second number is greater than first");
            }

           int userAge = Convert.ToInt32(Console.ReadLine());

           if(userAge>=18 && userAge<28)
           {System.Console.WriteLine("You are eligible to military service");}

           else
           {System.Console.WriteLine("You are not eligible to military service");}
    }
}
}