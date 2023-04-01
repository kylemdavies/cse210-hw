using System;

public class Race : Persona
{
    protected string _race;
    protected string [] _races = {"Dwarf", "Elf", "Halfling", "Human", "Dragonborn", "Gnome", "Half-elf", "Half-orc", "Tiefling", "Aarakocra", "Genasi", "Goliath", "Changelings", "Goblinoids", "Kalashtar", "Orc", "Shifters", "Warforged", "Corvian", "Crystalkin", "Deepling", "Fairy", "Centaur", "Leonin", "Minotaur", "Satyr", "Triton", "Aasimar", "Firbolgs", "Kenku", "Tortles", "Simic Hybrid", "Vedalken", "Loxodon", "Tabaxi", "Hollow One"};
    public Race(string name, int age) : base(name, age)
    {
        
    }
    public override void setRace(string race)
    {
        _race = race;
    }
    public override string getRace()
    {
        return _race;
    }
    public override string[] getRaces()
    {
        return _races;
    }
    public override void setRaceRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_races.Count());
        _race = _races[num];
    }
}