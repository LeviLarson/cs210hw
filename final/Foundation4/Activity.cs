using System;

abstract class Activity
{
    private string _date;
    private int _time;

    public string GetDate()
    {
        return _date;
    }
    public int GetTime()
    {
        return _time;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{this.GetDate()}: Distance {this.GetDistance()}, Speed {this.GetSpeed()}, Pace {this.GetPace()}";
    }

}