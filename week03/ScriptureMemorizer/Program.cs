using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world, that He gave His only begotten son, that whosoever believes in Him shall not perish but have everlasting life";

        Scripture scripture = new Scripture(reference, verseText);

        // Loop through the scripture untill user quits or all words are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomNumbers(3);
        }
        Console.Clear();
        Console.WriteLine("All words are hidden. Well done!");
    }
}