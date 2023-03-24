using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        List<Persona> personas = new List<Persona>();
        List<string> stringPersonas = new List<string>();
        List<string> stories = new List<string>();
        string Menu = "Menu Options \n1. Characters \n2. Stories \n3. Save \n4. Load \n5. Quit";
        while (Choice != 6)
        {
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine()); 
            if (Choice == 1)
            {
                Console.WriteLine("1. New Random Character \n2. New Custom Character \n3. List Characters");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    //Will create a random "Character" (Persona) and then add it to the personas List
                    Console.Clear();
                }
                else if (Choice == 2)
                {
                    //Will display questions and give options for each attribute and create a cutomized "Character" (Persona) and then add it to the personas List
                    Console.Clear();
                }
                else
                {
                    //Will display the personas List
                    Console.Clear();
                }
            }
            else if (Choice == 2)
            {
                Console.WriteLine("1. New Random Story \n2. New Custom Story \n3. List Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    //Will create a random story and then add it to the stories List
                    Console.Clear();
                }
                else if (Choice == 2)
                {
                    //Will display questions like "What is the name of the city?" or "What is the bad guy after?" and then put the answers together in a "Madlibs" style story and then add it to the stories List
                    Console.Clear();
                }
                else
                {
                    //Will display the stories List
                    Console.Clear();
                }
            }
            else if (Choice == 3)
            {
                Console.WriteLine("1. Save Characters \n2. Save Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    // Will ask what they want the file to be called then saves the personas list to the file
                    Console.Clear();
                }
                else
                {
                    // Will ask what they want the file to be called then saves the stories list to the file
                    Console.Clear();
                }
            }
            else if (Choice == 4)
            {
                Console.WriteLine("1. Load Characters \n2. Load Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    // Will ask what the name of the file is then loads the personas list from the file
                    Console.Clear();
                }
                else
                {
                    // Will ask what the name of the file is then loads the stories list from the file
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("I hope you enjoied!");
                Console.Clear();
            }
        }
    }
}