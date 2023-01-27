using System;

class Program
{
    static void Main(string[] args)
    {
        string attentionLine = "-----------------------------------------------";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine($"Hello today is: {dateText}");
        int number = 0;
        while (number != 5)
        {
            Console.WriteLine($"What would you like to do today?");
            Console.WriteLine($"1: Make a Journal Entry");
            Console.WriteLine($"2: View Your Entries");
            Console.WriteLine($"3: Load Entries");
            Console.WriteLine($"4: Save Entries");
            Console.WriteLine($"5. Close Program");
            Console.WriteLine($"Enter the number of the action you would like to do:");
            number = int.Parse(Console.ReadLine());
            //Make entry
            if (number == 1) {
                
            }
            //Display entries
            else if (number == 2) {

            }
            //Load entries
            else if (number == 3) {
                Console.WriteLine("Please enter the filename (Ex. 'filename.txt')");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    
                }
            }
            //Save entries
            else if (number == 4) {
                Console.WriteLine("Please enter the filename (Ex. 'filename.txt')");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine();
                }
            }
            //Number entered is too high error
            else if (number >= 6) {
                Console.WriteLine(attentionLine);
                Console.WriteLine($"I'm sorry {number} is not an option please try another number!");
                Console.WriteLine(attentionLine);
            }
            //Close Program
            else {
                Console.WriteLine(attentionLine);
                Console.WriteLine($"Please come again!");
                Console.WriteLine(attentionLine);
            }
        }

        /*
        Read File:
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }

        Write File:
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }

        Set Date: 
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        */
    }
}