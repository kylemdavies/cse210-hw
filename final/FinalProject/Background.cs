using System;

public class Background : Persona
{
    protected string _background;
    public override void setBackground(string Background)
    {
        _background = Background;
    }
    public override string getBackground()
    {
        return _background;
    }
    public override void setBackgroundRandom(List<string> Backgrounds)
    {
        Random rnd = new Random();
        int num = rnd.Next(Backgrounds.Count());
        _background = Backgrounds[num];
    }
}