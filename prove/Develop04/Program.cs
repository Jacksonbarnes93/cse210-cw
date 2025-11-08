using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an activity: ");
            string choice = Console.ReadLine();
            if (choice == "1")
                new BreathingActivity("Breathing Activity", 
                    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.").Run();
            else if (choice == "2")
                new ReflectionActivity("Reflection Activity", 
                    "This activity will help you reflect on times in your life when you have shown strength and resilience.").Run();
            else if (choice == "3")
                new ListingActivity("Listing Activity", 
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.").Run();
            else if (choice == "4")
                break;
            else
            {
                Console.WriteLine("Invalid option. Try again.");
                Thread.Sleep(1500);
            }
        }
    }
}
