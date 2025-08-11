public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool complete = false) : base(shortName, description, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"You earned {GetPoints()} points");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetShortName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}