using System;

public class Specialty : Persona
{
    protected string _specialty;
    protected string [] _specialties = {"Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard", "Artificer"};
    
    public Specialty(string name, int age) : base(name, age)
    {
        
    }
    public override void setSpecialty(string specialty)
    {
        _specialty = specialty;
    }
    public override string getSpecialty()
    {
        return _specialty;
    }
    public override string[] getSpecialties()
    {
        return _specialties;
    }
    public override void setSpecialtyRandom()
    {
        Random rnd = new Random();
        int num = rnd.Next(_specialties.Count());
        _specialty = _specialties[num];
    }
}