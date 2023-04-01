using System;

public class Subrace : Persona
{
    protected string _subrace;
    protected string[] _subraces;
    public Subrace(string name, int age) : base(name, age)
    {
        
    }
    public override void setSubrace(string Subrace)
    {
        _subrace = Subrace;
    }
    public override string getSubrace()
    {
        return _subrace;
    }
    public override void setSubraces(string race)
    {
        if (race == "Dwarf"){
                string[] _subraces = {"Hill Dwarf", "Mountain Dwarf", "Duergar", "Ember Dwarf",
                    "Stone Dwarf", "Tundra Dwarf"};

            }
            else if (race == "Elf") {
                string[] _subraces = {"High Elf", "Wood Elf", "Dark Elf (Drow)", "Moon Elf", 
                    "Sun Elf", "Pallid Elf", "Sea Elf", "Bright Elf", "Green Elf", 
                    "Thimble Elf"};

            }
            else if (race == "Halfling") {
                string[] _subraces = {"Lightfoot", "Stout", "Jungle Halfling", "River Halfling",
                    "Lotusden", "Strongheart"};

            }
            else if (race == "Human") {
                string[] _subraces = {"None"};

            }
            else if (race == "Dragonborn") {
                string[] _subraces = {"Black", "Blue", "Brass", "Bronze", "Copper", "Gold",
                "Green", "Red", "Silver", "White", "Draconblood", "Ravenite"};   

            }
            else if (race == "Gnome") {
                string[] _subraces = {"Forest Gnome", "Rock Gnome", "Deep Gnomes (Svirfneblin)"};

            }
            else if (race == "Half-elf") {
                string[] _subraces = {"Wood Elf (Variant)", "Moon Elf (Variant)", "Sun Elf (Variant)",
                    "Aquatic Elf (Variant)"};

            }
            else if (race == "Half-orc") {
                string[] _subraces = {"None"};

            }
            else if (race == "Tiefling") {
                string[] _subraces = {"Feral (Variant)", "Devil's Tongue (Variant)", 
                    "Hellfire (Variant)", "Winged (Variant)", "Apperance (Variant)"};

            }
            else if (race == "Aarakocra") {
                string[] _subraces = {"None"};

            }
            else if (race == "Genasi") {
                string[] _subraces = {"Air Genasi", "Earth Genasi", "Fire Genasi",
                    "Water Genasi", "Ash Genasi", "Ice Genasi", "Slime Genasi",
                    "Storm Genasi"};

            }
            else if (race == "Goliath") {
                string[] _subraces = {"None"};

            }
            else if (race == "Changelings") {
                string[] _subraces = {"None"};

            }
            else if (race == "Goblinoids") {
                string[] _subraces = {"Bugbear", "Goblin", "Hobgoblin"};

            }
            else if (race == "Kalashtar") {
                string[] _subraces = {"None"};

            }
            else if (race == "Orc") {
                string[] _subraces = {"None"};

            }
            else if (race == "Shifters") {
                string[] _subraces = {"Beasthide", "Longtooth", "Swiftstride", "Wildhunt"};

            }
            else if (race == "Warforged") {
                string[] _subraces = {"None"};

            }
            else if (race == "Corvian") {
                string[] _subraces = {"None"};

            }   
            else if (race == "Crystalkin") {
                string[] _subraces = {"Shardmind", "Glassheart"};

            }
            else if (race == "Deepling") {
                string[] _subraces = {"None"};

            }
            else if (race == "Fairy") {
                string[] _subraces = {"Pixies", "Sprites", "Scamps"};

            }
            else if (race == "Centaur") {
                string[] _subraces = {"None"};

            }
            else if (race == "Leonin") {
                string[] _subraces = {"None"};

            }
            else if (race == "Minotaur") {
                string[] _subraces = {"None"};

            }
            else if (race == "Satyr") {
                string[] _subraces = {"None"};

            }
            else if (race == "Triton") {
                string[] _subraces = {"None"};

            }
            else if (race == "Aasimar") {
                string[] _subraces = {"Protector Aasimar", "Scourge Aasimar", "Fallen Aasimar"};

            }
            else if (race == "Firbolgs") {
                string[] _subraces = {"None"};

            }
            else if (race == "Kenku") {
                string[] _subraces = {"None"};

            }
            else if (race == "Tortles") {
                string[] _subraces = {"None"};

            }
            else if (race == "Simic Hybrid") {
                string[] _subraces = {"None"};

            }
            else if (race == "Vedalken") {
                string[] _subraces = {"None"};

            }
            else if (race == "Loxodon") {
                string[] _subraces = {"None"};

            }
            else if (race == "Tabaxi") {
                string[] _subraces = {"None"};

            }
            else if (race == "Hollow One") {
                string[] _subraces = {"None"};

            }
    }
    public override string[] getSubraces()
    {
        return _subraces;
    }
    public override void setSubraceRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_subraces.Count());
        _subrace = _subraces[num];
    }
}