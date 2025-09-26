using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to my Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please write your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int birthYear)
    {
        Console.Write("What year were you born? ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squared, int birthYear)
    {
        int age = DateTime.Now.Year - birthYear;
        Console.WriteLine($"\n{name}, the square of your number is {squared}.");
        Console.WriteLine($"You will turn {age} this year.");
    }

    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favNumber = PromptUserNumber();

        PromtUserBirthYear(out int birthYear);

        int squared = SquareNumber(favNumber);

        DisplayResult(userName, squared, birthYear);
    }
}
