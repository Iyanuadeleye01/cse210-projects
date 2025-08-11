

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus, int completed = 0) : base(shortName, description, points)
    {
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress: {_amountCompleted}/{_target}");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal completed! {_bonus} points");
        }
        else
        {
            Console.WriteLine($"You earned {GetPoints()} ponts");
        }

    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $"---Completed {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal| {GetShortName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }
    
}