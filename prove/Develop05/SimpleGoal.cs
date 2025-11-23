using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;

            Console.WriteLine("\n✨✨ CONGRATULATIONS!!! ✨✨");
            Console.WriteLine($"You completede the goal: {Name}");
            Console.WriteLine("    *\\(^o^)/*  \n");

            return Points;
        }

        return 0;
    }
    public override string GetStatus()
    {
        return _isComplete ? $"[X] {Name}" : $"[ ] {Name}";
    }

    public override string SaveString()
    {
        return $"Simple|{Name}|{Description}|{Points}|{_isComplete}";
    }
}
