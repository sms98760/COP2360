// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Call the method to perform division
        PerformDivision();
    }

    // Method that takes two strings, converts to integers, and performs division
    static void PerformDivision()
    {
        Console.WriteLine("Enter two numbers to divide:");

        // Read input strings
        Console.Write("Enter the first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the second number: ");
        string input2 = Console.ReadLine();

        try
        {
            // Convert inputs to integers
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            // Perform division
            int result = num1 / num2;

            // Print the result
            Console.WriteLine($"The result of dividing {num1} by {num2} is: {result}");
        }
        catch (FormatException)
        {
            // Caught when input cannot be converted to integer
            Console.WriteLine("Error: Please enter valid integer numbers.");
        }
        catch (DivideByZeroException)
        {
            // Caught when dividing by zero
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            // Catches any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

