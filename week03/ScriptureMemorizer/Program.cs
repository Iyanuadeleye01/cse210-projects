using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the word");
        scripture.HideRandomNumbers(3);
        Console.WriteLine(scripture.GetDisplayText());
    }
}