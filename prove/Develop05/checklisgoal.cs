using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points,
    int targetCount, int bonusPoints, int timesCompleted = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted == _targetCount)
        {
            Console.WriteLine("\n🎉🎉 CHECKLIST COMPLETE!!! 🎉🎉");
            Console.WriteLine($"You finished '{Name}' and earned a bonus of {_bonusPoints}!");
            Console.WriteLine("    (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧\n");

            return Points + _bonusPoints;
        }

        Console.WriteLine($"\nProgress on {Name}: {_timesCompleted}/{_targetCount}");
        Console.WriteLine("Keep going! You earned points!");
        Console.WriteLine("   ^_^   \n");

        return Points;
    }

    public override string GetStatus()
    {
        string check = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        return $"{check} {Name} — Completed {_timesCompleted}/{_targetCount}";
    }

    public override string SaveString()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{_timesCompleted}|{_targetCount}|{_bonusPoints}";
    }
}
