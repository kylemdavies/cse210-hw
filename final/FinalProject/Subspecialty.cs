using System;

public class Subspecialty : Persona
{
    protected string _subspecialty;
    public override void setSubspecialty(string specialty)
    {
        if (specialty == "Barbarian")
        {
            string[] _subspecialties = {"Berserker", "Totem Warrior", "Quake Bringer", "Sky Caller", "Verdant Warden", "Ancestral Gardian", "Storm Herald", "Zealot"};
        }
        else if (specialty == "Bard")
        {
            string[] _subspecialties = {"Lore", "Valor", "Eloquence", "Journeys", "Glamour", "Swords", "Whispers"};
        }
        else if (specialty == "Cleric")
        {
            string[] _subspecialties = {"Knowledge", "Life", "Light", "Nature", "Tempest",
                    "Trickery", "War", "Arcana", "Mountain", "Sea", "Travel",
                    "Winter", "Forge", "Grave", "Order"};
        }
        else if (specialty == "Druid")
        {
            string[] _subspecialties = {"Land", "Moon", "Swords", "Seeds", "Storms",
                    "Dreams", "Shepherd", "Spores"};
        }
        else if (specialty == "Fighter")
        {
            string[] _subspecialties = {"Champion", "Battle Master","Eldritch Knight", 
                    "Purple Dragon Knight", "Flame Dancer", "Wind Knight",
                    "Arcane Archer", "Cavalier", "Samurai", "Echo Knight"};
        }
        else if (specialty == "Monk")
        {
            string[] _subspecialties = {"Open Hand", "Shadow", "Four Elements", "Long Death",
                    "Sun Soul", "Flying Fist", "Drunken Master", "Kensei"};
        }
        else if (specialty == "Paladin")
        {
            string[] _subspecialties = {"Devotion", "Ancients", "Vengeance", "Glory", "Crown",
                    "Dynamism", "Purification", "Conquest", "Redemption"};
        }
        else if (specialty == "Ranger")
        {
            string[] _subspecialties = {"Hunter", "Beast Master", "Fire Keeper", "Mariner",
                    "Gloom Stalker", "Horizon Walker", "Monster Slayer"};
        }
        else if (specialty == "Rogue")
        {
            string[] _subspecialties = {"Thief", "Assassin", "Arcane Trickster", "Mastermind",
                    "Swashbuckler", "Aerialist", "Inquisitive", "Scout"};
        }
        else if (specialty == "Sorcerer")
        {
            string[] _subspecialties = {"Draconic Bloodline", "Wild Magic", "Storm Sorcery",
                    "Cosmic Affinity", "Elemental Magic", "Green Thumb", "Divine Soul",
                    "Shadow"};
        }
        else if (specialty == "Warlock")
        {
            string[] _subspecialties = {"The Archfey", "The Fiend", "The Great Old One", 
                    "The Undying", "The Dragon", "The Celestial", "The Hexblade"]};
        }
        else if (specialty == "Wizard")
        {
            string[] _subspecialties = {"Abjuration", "Conjuration", "Divination", "Enchantment",
                    "Evocation", "Illusion", "Necromancy", "Transmutation", "Bladesinging",
                    "War", "Chronurgy", "Graviturgy"};
        }
        else
        {
            string[] _subspecialties = {"Alchemist", "Artillerist", "Battle Smith"};
        }
        _subspecialty = subspecialty;
    }
    public override string getSubspecialty()
    {
        return _subspecialty;
    }
    public override void setSubspecialtyRandom(List<string> subspecialties)
    {
        Random rnd = new Random();
        int num = rnd.Next(subspecialties.Count());
        _subspecialty = subspecialties[num];
    }
}