using System;

public class Subrace : Persona
{
    protected string _subrace;
    protected List<string> _subraces;
    public override void setSubrace(string Subrace)
    {
        _subrace = Subrace;
    }
    public override string getSubrace()
    {
        return _subrace;
    }
    public override void setSubraceRandom(List<string> Subraces)
    {
        Random rnd = new Random();
        int num = rnd.Next(Subraces.Count());
        _subrace = Subraces[num];
    }
}