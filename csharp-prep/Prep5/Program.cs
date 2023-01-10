using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = userName();
        float number = userNumber();
        float square = squareNumber(number);

        displayResult(name, square);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string userName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static float userNumber()
    {
        Console.Write("Please enter your favorite number: ");
        float number = float.Parse(Console.ReadLine());

        return number;
    }
    static float squareNumber(float number)
    {
        float square = number * number;

        return square;
    }
    static void displayResult(string name, float square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}