using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCSV());
            }
        }
        Console.WriteLine("Journal saved\n");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                _entries.Add(Entry.FromCSV(line));
            }
            Console.WriteLine("Journal loaded successfully");
        }

        else
        {
            Console.WriteLine("File not found");
        }
    }

}