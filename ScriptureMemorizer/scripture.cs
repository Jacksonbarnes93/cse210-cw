using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    public Scripture(Reference reference, string text)
    {
    _reference = reference;
    _words = new List<Word>();
        foreach (var w in text.Split(' '))
        {
            _words.Add(new Word(w));
        }
        _random = new Random();
    }
    public void Display()
    {
    Console.WriteLine(_reference.ToString());
    foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }
    public void HideRandomWords(int count = 3)
    {
        for (int i = 0; i < count; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public bool AllWordsHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
