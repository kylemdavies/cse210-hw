using System;

public class SimpleGoal : Goal
{
    //if it is complete it will be set to 1
    private int _complete = 0;

    public override void SetComplete(int complete)
    {
        _complete = complete;
    }
    public override int IsComplete()
    {
        return _complete;
    }
}