using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your percentage score?");
        string score = Console.ReadLine();
        int scoreNumber = int.Parse(score);
        string letter = "";

        if (scoreNumber >= 90)
        {
            letter = "A";
        }

        else if (scoreNumber >= 80)
        {
            letter = "B";
        }
        else if (scoreNumber >= 70)
        {
            letter = "C";
        }
        else if (scoreNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (scoreNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("Sorry! You didn't pass, you can do better next time");
        }
    }
}
