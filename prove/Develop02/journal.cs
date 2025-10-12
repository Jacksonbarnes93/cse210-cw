using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Journal
{
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you learn today that you can remerber from memory?",
        "What part of today changed you?",
        "What did you do today that prepared you for tommorow?",
    };
    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response);
        entries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved to JSON file.");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File was not found.");
            return;
        }
        string json = File.ReadAllText(filename);
        var loadedEntries = JsonSerializer.Deserialize<List<Entry>>(json);
        if (loadedEntries != null)
        {
            entries = loadedEntries;
            Console.WriteLine("Journal was loaded from JSON file.\n");
            DisplayJournal();
        }
        else
        {
            Console.WriteLine("No valid entries were found in the file.");
        }
    }
}
