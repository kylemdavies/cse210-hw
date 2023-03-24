using System;

public class Subspecialty : Persona
{
    protected string _subspecialty;
    protected List<string> _subspecialties;
    public override void setSubspecialty(string subspecialty)
    {
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