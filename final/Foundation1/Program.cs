using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();
        Video v1 = new Video("How to Build a PC", "TechMaster", 540);
        v1.AddComment(new Comment("Alice", "Great tutorial!"));
        v1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        v1.AddComment(new Comment("Charlie", "I built my PC following this."));
        videos.Add(v1);
        Video v2 = new Video("C# Classes Explained", "CodeLab", 430);
        v2.AddComment(new Comment("DevGuy", "This was super clear!"));
        v2.AddComment(new Comment("Student123", "Thanks for the examples."));
        v2.AddComment(new Comment("Mia", "Now I understand constructors!"));
        videos.Add(v2);
        Video v3 = new Video("Beginner Workout Routine", "FitLife", 615);
        v3.AddComment(new Comment("Jake", "Great tips!"));
        v3.AddComment(new Comment("Sam", "This is exactly what I needed."));
        v3.AddComment(new Comment("Tony", "Day 1, let's go!"));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (sec): {video.LengthSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($"  {c.CommenterName}: {c.Text}");
            }

            Console.WriteLine("\n-----------------------------\n");
        }
    }
}
