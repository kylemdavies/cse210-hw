using System;

public class MultiUseGoal : Goal
{
    private int _complete = 0;
    private int _times = 0;

    public int GetTimes()
    {
        return _times;
    }

    public void SetTimes(int times)
    {
        _times = times;
    }

    public override void SetComplete(int complete)
    {
        _complete = complete;
    }
    public override int IsComplete()
    {
        return _complete;
    }
}