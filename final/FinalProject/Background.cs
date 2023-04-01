using System;

public class Background : Persona
{
    protected string _background;
    protected string[] _backgrounds = {"Acolyte", "Charlatan", "Criminal", "Entertainer", "Spy", "Gladiator", "Guild Artisan", "Guild Merchant", "Hermit", "Noble", "Knight", "Outlander", "Sage", "Sailor", "Pirate", "Soldier", "Urchin", "House Agent", "City Watch", "Investigator", "Clan Crafter", "Cloistered Scholar", "Courtier", "Faction Agent", "Far Traveler", "Inheritor", "Knight of the Order", "Mercenary Vetran", "Urban Bounty Hunter","Uthgardt Tribe Member", "Waterdhavian Noble", "Hidden Villager", "Planar Traveler", "Grinner", "Volstrucker Agent", "Athlete"};
    public Background(string name, int age) : base(name, age)
    {
        
    }
    public override void setBackground(string Background)
    {
        _background = Background;
    }
    public override string getBackground()
    { 
        return _background;
    }
    public override string[] getBackgrounds()
    { 
        return _backgrounds;
    }
    public override void setBackgroundRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_backgrounds.Count());
        _background = _backgrounds[num];
    }
}