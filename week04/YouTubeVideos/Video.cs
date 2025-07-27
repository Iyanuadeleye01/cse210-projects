using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _LengthInSeconds;
    public List<Comment> _comments = new List<Comment>();
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"LengthInSeconds: {_LengthInSeconds}");
        Console.WriteLine($"Number of Comments: {_comments.Count}");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }
}