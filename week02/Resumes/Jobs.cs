using System;
public class Job
{
    public string _comapany;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($" {_comapany} {_jobTitle} {_startYear}-{_endYear}");
    }
}
