using System;

public class Persona
{
    protected string _name;
    protected int _age;

    public void setName(string name)
    {
    _name = name;
    }
    public string getName()
    {
    return _name;
    }
    public void setAge(int age)
    {
        _age = age;
    }
    public int getAge()
    {
        return _age;
    }
    public virtual void setSpecialty(string specialty)
    {

    }
    public virtual string getSpecialty()
    {
        return "";
    }
    public virtual void setSpecialtyRandom()
    {

    }
    public virtual void setSubspecialty(string specialty)
    {

    }
    public virtual string getSubspecialty()
    {
        return "";
    }
    public virtual void setSubspecialtyRandom(string specialty)
    {

    }
    public virtual void setRace(string race)
    {

    }
    public virtual string getRace()
    {
        return "";
    }
    public virtual void setRaceRandom()
    {

    }
    public virtual void setSubrace(string race)
    {

    }
    public virtual string getSubrace()
    {
        return "";
    }
    public virtual void setSubraceRandom(string race)
    {

    }
    public virtual void setBackground(string Background)
    {

    }
    public virtual string getBackground()
    {
        return "";
    }
    public virtual void setBackgroundRandom()
    {

    }

}