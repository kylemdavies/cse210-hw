using System;

public class SimpleGoal : Goal
{
    //if it is complete it will be set to 1
    private float _complete = 0;

    public override void SetComplete(float complete)
    {
        _complete = complete;
    }
    public override float IsComplete()
    {
        return _complete;
    }
}