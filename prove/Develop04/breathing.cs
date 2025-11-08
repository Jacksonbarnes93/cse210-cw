using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
        : base(name, description) { }
    public void Run()
    {
        DisplayStartMessage();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.Write("\nBreathe out... ");
            Countdown(3);
            elapsed += 6;
        }
        DisplayEndMessage();
    }
}
