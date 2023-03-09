using System;

public class EternalGoal : Goal
{
    private int _complete = 0;

    public override int IsComplete()
    {
        return _complete;
    }
}