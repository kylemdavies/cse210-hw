using System;

public class Race : Persona
{
    protected string _race;
    protected List<string> _races;
    public override void setRace(string race)
    {
        _race = race;
    }
    public override string getRace()
    {
        return _race;
    }
    public override void setRaceRandom(List<string> races)
    {
        Random rnd = new Random();
        int num = rnd.Next(races.Count());
        _race = races[num];
    }
}