using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        Console.WriteLine("\nNice work! Keep it up!");
        Console.WriteLine("You earned points!");
        Console.WriteLine("  (•‿•)  \n");

        return Points;
    }





    public override string GetStatus()
    {
        return $"[∞] {Name}";
    }
    public override string SaveString()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}
