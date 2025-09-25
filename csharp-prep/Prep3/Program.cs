using System;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number: ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess: ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != magicNumber)
        {
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("Try again: ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Correct! You guessed it!");
    }
}