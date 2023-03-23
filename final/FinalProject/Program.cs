using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        List<Persona> Personas = new List<Persona>();
        List<string> stringPersonas = new List<string>();
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
                    
                }
                else if (Choice == 2)
                {
                    
                }
                else
                {

                }
            }
            else if (Choice == 2)
            {
                Console.WriteLine("1. New Random Story \n2. New Custom Story \n3. List Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {

                }
                else if (Choice == 2)
                {
                    
                }
                else
                {
                    
                }
            }
            else if (Choice == 3)
            {
                Console.WriteLine("1. Save Characters \n2. Save Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {

                }
                else
                {
                    
                }
            }
            else if (Choice == 4)
            {
                Console.WriteLine("1. Load Characters \n2. Load Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {

                }
                else
                {
                    
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