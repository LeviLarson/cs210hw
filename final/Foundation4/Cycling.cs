using System;

class Cycling : Activity
{
    private double _speed;

    public Cycling(double speed, int time, string date) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed/60) * this.GetTime();
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / this.GetSpeed();
    }
}