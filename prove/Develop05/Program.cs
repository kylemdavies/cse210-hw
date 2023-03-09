using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        string Menu = "Menu Options \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit";
        while (Choice != 4)
        {
            //Displays Menu and Reads response
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine());
            List<Goal> goals = new List<Goal>();
            int Goaltype = 0;
            //Create Goals
            if (Choice == 1)
            {
                Console.WriteLine("1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                Console.WriteLine($"v Select a choice from the menu: ");
                Goaltype = int.Parse(Console.ReadLine());
                if (Goaltype == 1)
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.SetName(name);
                    sGoal.SetDescription(description);
                    sGoal.SetPoints(points);
                    goals.Add(sGoal);
                }
                else if (Goaltype == 2)
                {

                }
                else
                {

                }
            }
            //List Goals
            else if (Choice == 2)
            {
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{goal.GetName()} : {goal.GetDescription()}");
                }
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