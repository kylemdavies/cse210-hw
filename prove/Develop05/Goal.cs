using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points = 0;

    public Goal()
    {
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    
    private int _complete = 0;

    public virtual void SetComplete(int complete)
    {
        _complete = complete;
    }
    public virtual int IsComplete()
    {
        return 0;
    }
}