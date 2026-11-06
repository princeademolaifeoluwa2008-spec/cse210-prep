using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public void Display()
    {
        int wordCount = _entryText.Split(' ').Length;
        Console.WriteLine($"\nDate: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood} - Words: {wordCount}");
        Console.WriteLine($"{_entryText}");
    }
}
