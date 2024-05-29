using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello!");

        // Get the first number from the user
        Console.WriteLine("Input the first number: ");
        string userInputFirstNumber = Console.ReadLine();
        int firstNumber = int.Parse(userInputFirstNumber);

        // Get the second number from the user
        Console.WriteLine("Input the second number: ");
        string userInputSecondNumber = Console.ReadLine();
        int secondNumber = int.Parse(userInputSecondNumber);

        // Prompt user for operation choice
        Console.WriteLine("What do you want to do with those number? ");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiply");

        string userChoice = Console.ReadLine();

        // Convert user choice to upper case to handle both cases
        userChoice = userChoice.ToUpper();


        // Perform the appropriate operation base on user choice
        if (userChoice == "A")
        {
            var sum = firstNumber + secondNumber;
            PrintFinalEquation(firstNumber, secondNumber, sum, "+");
        }

        else if (userChoice == "S")
        {
            var difference = firstNumber - secondNumber;
            PrintFinalEquation(firstNumber, secondNumber, difference, "-");
        }

        else if (userChoice == "M")
        {
            var multiplied = firstNumber * secondNumber;
            PrintFinalEquation(firstNumber, secondNumber, multiplied, "*");
        }

        else
        {
            Console.WriteLine("Invalid choice! Please select from one of the given options.");
        }

        Console.WriteLine("Press any key to close");
        Console.ReadKey();

        void PrintFinalEquation(int firstNumber, int secondNumber, int result, string @operator)
        {
            Console.WriteLine($"{firstNumber} {@operator} {secondNumber} = {result}");
        }
    }
}
