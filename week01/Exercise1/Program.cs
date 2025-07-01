using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your firstname?");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastname = Console.ReadLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");

    }
}