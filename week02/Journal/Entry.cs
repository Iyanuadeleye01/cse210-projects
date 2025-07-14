using System;
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");

    }
    public string ToCSV()
    {
        return $"{_date}, {_promptText}, {_entryText}";
    }
    public static Entry FromCSV(string line)
    {
        string[] content = line.Split(",");
        return new Entry
        {
            _date = content[0],
            _promptText = content[1],
            _entryText = content[2]
        };
    }
}