using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public void Start()
    {
        int choice = -1;
        while (choice != 6)
        {
            Console.WriteLine($"\nCurrent Score: {_score} points\n");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Sae goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
                continue;

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ShowGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
            _goals.Add(new SimpleGoal(name, desc, points));

        else if (choice == 2)
            _goals.Add(new EternalGoal(name, desc, points));

        else if (choice == 3)
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

        Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }



    private void ShowGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            var g = _goals[i];
            Console.WriteLine($"{i + 1}. {g.GetStatus()} {g.Name}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (StreamWriter w = new StreamWriter(file))
        {
            w.WriteLine(_score);
            foreach (var g in _goals)
                w.WriteLine(g.SaveString());
        }

        Console.WriteLine("Saved.");
    }

    private void LoadGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));

            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));

            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[4]), int.Parse(parts[5])
                ));
        }

        Console.WriteLine("Loaded.");
    }






    private void RecordEvent()
    {
        ShowGoals();
        Console.Write("Which goal? ");
        int idx = int.Parse(Console.ReadLine()) - 1;

        if (idx < 0 || idx >= _goals.Count)
            return;

        int gained = _goals[idx].RecordEvent();
        _score += gained;

        if (gained > 0)
            CelebrationAnimation();

        Console.WriteLine($"You gained {gained} points!");
    }

    private void CelebrationAnimation()
    {
        Console.WriteLine("\n✨🎉 CONGRATULATIONS! 🎉✨");
        Console.WriteLine("  ___   _   _   ___   _   _  ");
        Console.WriteLine(" / _ \\ | | | | / _ \\ | | | | ");
        Console.WriteLine("| | | || | | || | | || | | | ");
        Console.WriteLine("| |_| || |_| || |_| || |_| | ");
        Console.WriteLine(" \\___/  \\___/  \\___/  \\___/  ");
        Console.WriteLine("You completed a goal!");
        Console.WriteLine();
    }
}
