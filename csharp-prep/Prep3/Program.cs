using System;

class Program
{
    static void Main(string[] args)
    {
        string keepGoing = "Y";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,10);
        int guess = 0;

        do
        {
            if (keepGoing == "Y")
            {
                while (guess != number)
                {
                    Console.Write("Guess a Number? ");
                    string userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                    if (guess < number)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You Got It!");
                    }
                }
            }
            Console.Write("Do you want to continue? (Y/N) ");
            keepGoing = Console.ReadLine();
            keepGoing = keepGoing.ToUpper();
        } while (keepGoing == "Y");
    }
}