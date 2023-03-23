using System;

public class Specialty
{
    protected string _specialty;
    protected List<string> _specialties;

    public override void setSpecialty(string specialty)
    {
        _specialty = specialty;
    }
    public override string getSpecialty()
    {
        return _specialty;
    }
    public override void setSpecialtyRandom(List<string> specialties)
    {

    }
}