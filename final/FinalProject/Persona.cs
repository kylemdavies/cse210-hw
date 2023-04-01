using System;

public abstract class Persona
{
    protected string _name;
    protected int _age;

    public Persona(string name, int age)
    {

    }
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
    public abstract void setSpecialty(string specialty);
    public abstract string getSpecialty();

    public abstract string[] getSpecialties();
    public abstract void setSpecialtyRandom();;
    public abstract void setSubspecialty(string Subspecialty);
    public abstract string getSubspecialty();
    public abstract void setSubspecialties(string specialty);
    public abstract string[] getSubspecialties();
    public abstract void setSubspecialtyRandom();
    public abstract void setRace(string race);
    public abstract string getRace();
    public abstract string[] getRaces();
    public abstract void setRaceRandom();
    public abstract void setSubrace(string race);
    public abstract string getSubrace();
    public abstract void setSubraces(string races);
    public abstract string[] getSubraces();
    public abstract void setSubraceRandom();
    public abstract void setBackground(string Background);
    public abstract string getBackground();
    public abstract string[] getBackgrounds();
    public abstract void setBackgroundRandom();
    public void displayList(string[] list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}