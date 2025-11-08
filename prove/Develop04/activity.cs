using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Spinner(3);
    }
    protected void DisplayEndMessage()
    {
        Console.WriteLine("\nGood job!");
        Spinner(2);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");
        Spinner(3);
    }



    protected void Spinner(int seconds)
    {
        string[] sequence = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(sequence[i % sequence.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
