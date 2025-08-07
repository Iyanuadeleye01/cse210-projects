using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Doe","Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        //Mathassignment class
        MathAssignment assignment2 = new MathAssignment("Iyanu Adeleye","Addition","7.3","8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        //Writingassignment class
        WritingAssignment assignment3 = new WritingAssignment("Martins Lilian","Fractions","Fundamental Algebra");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWrittingInformation());
    }
}