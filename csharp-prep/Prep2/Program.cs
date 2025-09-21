using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradepercentage = int.Parse(grade);

        string lettergrade = "";

        
        if (gradepercentage >= 90)
        {
            lettergrade = "A";
        }
        else if (gradepercentage >= 80)
        {
            lettergrade = "B";
        }
        else if (gradepercentage >= 70)
        {
            lettergrade = "C";
        }
        else if (gradepercentage >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }

        Console.WriteLine($"Your grade is: {lettergrade}");
        
        if (gradepercentage >= 70)
        {
            Console.WriteLine("You passed your class great job!");
        }
        else
        {
            Console.WriteLine("You didn't get it this time, good luck next time!");
        }

    }
}