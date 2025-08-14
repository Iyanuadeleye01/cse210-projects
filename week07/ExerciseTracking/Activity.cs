public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
     public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} mins): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }

}