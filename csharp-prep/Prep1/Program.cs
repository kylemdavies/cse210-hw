using System;

class Program
{
    static void Main(string[] args)
    {
        String FName = "";
        String LName = "";
        Console.WriteLine("What is your First Name?  ");
        FName = Console.ReadLine();
        Console.WriteLine("What is your Last Name?  ");
        LName = Console.ReadLine();
        Console.WriteLine($"Your name is {LName}, {FName} {LName}");
    }
}