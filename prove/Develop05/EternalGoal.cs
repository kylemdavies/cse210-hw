using System;

public class EternalGoal : Goal
{
    private float _complete = 0;

    public override float IsComplete()
    {
        return _complete;
    }
}