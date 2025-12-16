using System;
public class Activity
{
    private DateTime _date;
    private int _minutes;
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    protected int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }
}
