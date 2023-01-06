using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // Letter Grade Reveal

        Console.WriteLine("What is your Percentage Grade? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);
        string letterGrade = "";
        if (number >= 90) {
            letterGrade = "A";
        }
        else if (number >= 80) {
            letterGrade = "B";
        }
        else if (number >= 70) {
            letterGrade = "C";
        }
        else if (number >= 60) {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }
        Console.WriteLine($"Your Grade is {letterGrade}.");
        
        //Pass or Fail Message 

        if (number >= 70) {
            Console.WriteLine($"Congrats! You passed!");
        }
        else {
            Console.WriteLine($"Darn! Try again next time!");
        }
    }
}