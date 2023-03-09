using System;

public class SimpleGoal : Goal
{
    //if it is complete it will be set to 1
    private int _complete = 0;

    public int GetCommplete()
    {
        return _complete;
    }

    public void SetComplete(int complete)
    {
        _complete = complete;
    }
}