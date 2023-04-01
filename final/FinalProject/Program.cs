using System;

class Program
{
    static void Main(string[] args)
    {
        int Choice = 0;
        List<string> personas = new List<string>();
        List<string> stories = new List<string>();
        string Menu = "Menu Options \n1. Characters \n2. Stories \n3. Save \n4. Load \n5. Quit";
        while (Choice != 5)
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
                    Console.WriteLine("What is this Characters name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is this Characters age?");
                    int age = int.Parse(Console.ReadLine());
                    Persona persona = new Persona(name, age);
                    persona.setSpecialtyRandom();
                    persona.setRaceRandom();
                    persona.setBackgroundRandom();
                    string specialty = persona.getSpecialty();
                    string race = persona.getRace();
                    string background = persona.getBackground();
                    persona.setSubspecialties(specialty);
                    persona.setSubspecialtyRandom();
                    persona.setSubraces(race);
                    persona.setSubraceRandom();
                    string subspecialty = persona.getSubspecialty();
                    string subrace = persona.getSubrace();
                    Console.WriteLine($"Race: {race}\nSubrace: {subrace}\nClass: {specialty}\nSubclass: {subspecialty}\nBackground: {background}");
                    persona.setName(name);
                    persona.setAge(age);
                    personas.Add($"Name: {name}\nAge: {age}\nRace: {race}\nSubrace: {subrace}\nClass: {specialty}\nSubclass: {subspecialty}\nBackground: {background}");
                    Console.WriteLine("You successfully created a random Character!");
                }
                else if (Choice == 2)
                {
                    //Will display questions and give options for each attribute and create a cutomized "Character" (Persona) and then add it to the personas List
                    Console.WriteLine("What is this Characters name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is this Characters age?");
                    int age = int.Parse(Console.ReadLine());
                    Persona persona = new Persona(name, age);
                    Console.WriteLine("Please answer these questions with one of the provided options.");
                    Console.WriteLine("What race would you like your Character to be? The options are:");
                    Program.displayList(persona.getRaces());
                    Console.WriteLine("Please answer as written above or your Character might not turn out as expected.");
                    string race = Console.ReadLine();
                    persona.setRace(race);
                    persona.setSubraces(race);
                    //End of Race
                    Console.WriteLine("What subrace would you like your Character to be? The options are:");
                    Program.displayList(persona.getSubraces());
                    Console.WriteLine("Please answer as written above or your Character might not turn out as expected.");
                    string subrace = Console.ReadLine();
                    persona.setSubrace(subrace);
                    //End of Subrace
                    Console.WriteLine("What class would you like your Character to be? The options are:");
                    Program.displayList(persona.getSpecialties());
                    Console.WriteLine("Please answer as written above or your Character might not turn out as expected.");
                    string specialty = Console.ReadLine();
                    persona.setSpecialty(specialty);
                    persona.setSubspecialties(specialty);
                    //End of Specialty
                    Console.WriteLine("What subclass would you like your Character to be? The options are:");
                    Program.displayList(persona.getSubspecialties());
                    Console.WriteLine("Please answer as written above or your Character might not turn out as expected.");
                    string subspecialty = Console.ReadLine();
                    persona.setSubspecialty(specialty);
                    //End of Subspecialty
                    Console.WriteLine("What background would you like your Character to have? The options are:");
                    Program.displayList(persona.getBackgrounds());
                    Console.WriteLine("Please answer as written above or your Character might not turn out as expected.");
                    string background = Console.ReadLine();
                    persona.setBackground(background);
                    Console.WriteLine($"Race: {race}\nSubrace: {subrace}\nClass: {specialty}\nSubclass: {subspecialty}\nBackground: {background}");
                    
                    persona.setName(name);
                    persona.setAge(age);
                    personas.Add($"Name: {name}\nAge: {age}\nRace: {race}\nSubrace: {subrace}\nClass: {specialty}\nSubclass: {subspecialty}\nBackground: {background}"); 
                    Console.WriteLine("You successfully created a Character!");
                }
                else
                {
                    //Will display the personas List
                    foreach (string persona in personas)
                    {
                        Console.WriteLine(persona);
                    }
                    Console.WriteLine("Here is your list of Characters!");
                }
            }
            else if (Choice == 2)
            {
                Console.WriteLine("1. New Random Story \n2. New Custom Story \n3. List Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    //Will create a random story and then add it to the stories List
                    Word story = new Word();
                    story.setCityTypeRandom();
                    story.setTownNameRandom();
                    story.setLocationRandom();
                    story.setNameRandom();
                    story.setItemRandom();
                    story.setTitleRandom();
                    string townType = story.getCityType();
                    string town = story.getTownName();
                    string location = story.getLocation();
                    string name = story.getName();
                    string item = story.getItem();
                    string title = story.getTitle();
                    Console.WriteLine($"In a {townType} environment lies a town called {town}. In the {location} we find our adventurers. These merry few are pitted against {name}, the {title}, who is on the search for the {item}.");
                    stories.Add($"In a {townType} environment lies a town called {town}. In the {location} we find our adventurers. These merry few are pitted against {name}, the {title}, who is on the search for the {item}.");
                    Console.WriteLine("You successfully created a random Story!");
                }
                else if (Choice == 2)
                {
                    //Will display questions like "What is the name of the city?" or "What is the bad guy after?" and then put the answers together in a "Madlibs" style story and then add it to the stories List
                    Word story = new Word();
                    Console.WriteLine("Please answer the following questions as to how you would like your story to be about?");
                    Console.WriteLine("What type of environment would you like this story to take place?");
                    string townType = Console.ReadLine();
                    story.setCityType(townType);
                    Console.WriteLine("What is the name of the town/city you would like this story to take place in?");
                    string town = Console.ReadLine();
                    story.setTownName(town);
                    Console.WriteLine("Where could we find the adventurers at in the beginning of this story?");
                    string location = Console.ReadLine();
                    story.setLocation(location);
                    Console.WriteLine("What is the name of the bad person in this story?");
                    string name = Console.ReadLine();
                    story.setName(name);
                    Console.WriteLine("What is their title that the villagers know them by?");
                    string title = Console.ReadLine();
                    story.setTitle(title);
                    Console.WriteLine("What is the item/items they are after?");
                    string item = Console.ReadLine();
                    story.setItem(item);
                    Console.WriteLine($"In a {townType} environment lies a town called {town}. In the {location} we find our adventurers. These merry few are pitted against {name}, the {title}, who is on the search for the {item}.");
                    stories.Add($"In a {townType} environment lies a town called {town}. In the {location} we find our adventurers. These merry few are pitted against {name}, the {title}, who is on the search for the {item}.");
                    Console.WriteLine("You successfully created a Story!");
                }
                else
                {
                    //Will display the stories List
                    Console.WriteLine("Here are your stories!");
                    foreach (string story in stories)
                    {
                        Console.WriteLine(story);
                    }
                }
            }
            else if (Choice == 3)
            {
                Console.WriteLine("1. Save Characters \n2. Save Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    // Will ask what they want the file to be called then saves the personas list to the file
                    Console.WriteLine("You successfully saved your characters!");
                }
                else
                {
                    // Will ask what they want the file to be called then saves the stories list to the file
                    Console.WriteLine("You successfully saved your stories!");
                }
            }
            else if (Choice == 4)
            {
                Console.WriteLine("1. Load Characters \n2. Load Stories");
                Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    // Will ask what the name of the file is then loads the personas list from the file
                    Console.WriteLine("You successfully loaded your characters!");
                }
                else
                {
                    // Will ask what the name of the file is then loads the stories list from the file
                    Console.WriteLine("You successfully loaded your stories!");
                }
            }
            else
            {
                Console.WriteLine("I hope you enjoied!");
                Console.Clear();
            }
        }
    }
    static void displayList(string[] list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}