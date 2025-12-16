using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * .62;
    }

    public override double GetSpeed()
    {
        return (this.GetDistance()/this.GetTime())*60;
    }

    public override double GetPace()
    {
        return 60 /this.GetSpeed();
    }
}