using System;

class Program
{
    static void Main(string[] args)
    {
     Reference reference = new Reference("John", 3, 16);
    Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            scripture.Display();
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! Good job memorizing the scripture!");
                break;
            }
            Console.WriteLine("\nPress Enter to hide a few words or type 'quit' to exit the program.");
            string input = Console.ReadLine().Trim().ToLower();
            if (input == "quit")
                break;
            scripture.HideRandomWords();
        }
    }
}
