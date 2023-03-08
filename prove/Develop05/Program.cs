using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        string Menu = "Menu Options \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit";
        while (Choice != 4)
        {
            //Displays Menu and Reads response
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine());
            List<string> goals = new List<string>();
            //Create Goals
            if (Choice == 1)
            {
                
            }
            //List Goals
            else if (Choice == 2)
            {

            }
            //Save Goals
            else if (Choice == 3)
            {

            }
            //Load Goals
            else if (Choice == 4)
            {

            }
            //Record Event
            else if (Choice == 5)
            {

            }
            else
            {

            }
        }
    }
}