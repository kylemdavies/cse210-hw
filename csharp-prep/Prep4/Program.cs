using System;

class Program
{
    static void Main(string[] args)
    {
        float sum = 0;
        float average = 0;
        float bigNum = 0;
        List<float> numbers = new List<float>();
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        Console.WriteLine(" Enter number: ");
        float input = float.Parse(Console.ReadLine());
        while (input != 0)
        {
            numbers.Add(input);
            Console.WriteLine(" Enter number: ");
            input = float.Parse(Console.ReadLine());
        }
        
        foreach (int number in numbers)
        {
            sum += number;
            if (number > bigNum)
            {
                bigNum = number;
            }
        }
        
        average = sum / numbers.Count;
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {bigNum}");
        
    }
}