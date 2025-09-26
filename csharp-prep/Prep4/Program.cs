using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter a number (tpe 0 to stop): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("That wasn't a valid integer. please try again.");
                continue;
            }

            if (value == 0)
                break; 
            numbers.Add(value);
        }
        if (numbers.Count > 0)
        {
            int sum = 0;
            foreach (int n in numbers)
                sum += n;

            double average = (double)sum / numbers.Count;

            int max = numbers[0];
            foreach (int n in numbers)
                if (n > max)
                    max = n;

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
