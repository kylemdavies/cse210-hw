using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        int totalPoints =  0;
        List<Goal> goals = new List<Goal>();
        string Menu = "Menu Options \n 1. Create New Goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit";
        while (Choice != 6)
        {
            //Displays Menu and Reads response
            string Break = $"--------------------------------------------- \nPoints: {totalPoints}\n---------------------------------------------";
            Console.WriteLine($"Points: {totalPoints}");
            Console.WriteLine($"{Menu}");
            Console.WriteLine($"v Select a choice from the menu: ");
            Choice = int.Parse(Console.ReadLine());
            Console.WriteLine(Break);
            int Goaltype = 0;
            //Create Goals
            if (Choice == 1)
            {
                Console.WriteLine("1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal");
                Console.WriteLine($"v Select a choice from the menu: ");
                Goaltype = int.Parse(Console.ReadLine());
                Console.WriteLine(Break);
                if (Goaltype == 1)
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    SimpleGoal sGoal = new SimpleGoal();
                    sGoal.SetGoalType("Simple Goal");
                    sGoal.SetName(name);
                    sGoal.SetDescription(description);
                    sGoal.SetPoints(points);
                    sGoal.SetComplete(0);
                    goals.Add(sGoal);
                }
                else if (Goaltype == 2)
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    EternalGoal eGoal = new EternalGoal();
                    eGoal.SetGoalType("Eternal Goal");
                    eGoal.SetName(name);
                    eGoal.SetDescription(description);
                    eGoal.SetPoints(points);
                    eGoal.SetComplete(0);
                    goals.Add(eGoal);
                }
                else
                {
                    Console.WriteLine($"What is the name of this goal?");
                    string name = (Console.ReadLine());
                    Console.WriteLine($"What is a short description of it?");
                    string description = (Console.ReadLine());
                    Console.WriteLine($"How many times would you like to complete this goal?");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine($"How many points is this worth?");
                    int points = int.Parse(Console.ReadLine());
                    ChecklistGoal cGoal = new ChecklistGoal();
                    cGoal.SetGoalType("Checklist Goal");
                    cGoal.SetName(name);
                    cGoal.SetDescription(description);
                    cGoal.SetPoints(points);
                    cGoal.SetComplete(0);
                    cGoal.SetTimes(times);
                    goals.Add(cGoal);
                }
            }
            //List Goals
            else if (Choice == 2)
            {
                foreach (Goal goal in goals)
                {
                    float completed = goal.IsComplete();
                    if (completed != 1)
                    {
                        Console.WriteLine($"[ ] {goal.GetName()} : {goal.GetDescription()}");
                    }
                    else
                    {
                        Console.WriteLine($"[✓] {goal.GetName()} : {goal.GetDescription()}");
                    }
                }
                Console.WriteLine(Break);
            }
            //Save Goals
            else if (Choice == 3)
            {
                Console.WriteLine(Break);
            }
            //Load Goals
            else if (Choice == 4)
            {
                Console.WriteLine(Break);
            }
            //Record Event
            else if (Choice == 5)
            {
                int indexNum = 1;
                float completed =  0;
                int timesCompleted = 1;
                foreach (Goal goal in goals)
                {
                    completed = goal.IsComplete();
                    
                    if (completed != 1)
                    {
                        string goalType = goal.GetGoalType();
                        if (goalType == "Checklist Goal")
                        {
                            Console.WriteLine($"{indexNum}. [ ] {goal.GetName()} : {goal.GetDescription()} [{completed}]");
                        }
                        else
                        {
                            Console.WriteLine($"{indexNum}. [ ] {goal.GetName()} : {goal.GetDescription()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{indexNum}. [✓] {goal.GetName()} : {goal.GetDescription()}");
                    }
                    indexNum += 1;
                }
                Console.WriteLine(Break);
                Console.WriteLine("Which goal did you acomplish?");
                int completedGoal = int.Parse(Console.ReadLine()) - 1;
                if (goals[completedGoal].GetGoalType() == "Checklist Goal")
                {
                    int pastTimes = goals[completedGoal].getTimesCompleted();
                    timesCompleted += pastTimes;
                }
                else
                {
                    timesCompleted = 1;
                }
                totalPoints = goals[completedGoal].GetPoints();
                goals[completedGoal].SetTimesCompleted(timesCompleted);
                
                Console.WriteLine($"Congrats on completing your goal of: {goals[completedGoal].GetName()}!");
                Console.WriteLine(Break);
                
            }
            else
            {
                Console.WriteLine("Hope you have a great day!");
                Console.Clear();
            }
        }
    }
}