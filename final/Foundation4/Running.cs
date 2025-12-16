using System;

class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, int time) : base(date, time)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / this.GetTime()) * 60;
    }
    public override double GetPace()
    {
        return this.GetTime() / _distance;
    }
    
}