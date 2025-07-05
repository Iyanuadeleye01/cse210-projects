using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        while (number > 0)
        {
            Console.WriteLine("Enter a number or enter 0 to exit the program");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        Console.WriteLine($"The sum is: {sum}");
        {
            float avg = ((float)sum) / numbers.Count;

            Console.WriteLine($"The average is: {avg}");
        }
        int max = numbers[0];
        int numberCount = numbers.Count;
        for (int i = 0; i < numberCount; i++)
        {
            Console.WriteLine(numbers[i]);

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
