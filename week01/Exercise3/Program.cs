using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Console.WriteLine("Enter the magic number");
        // string magic_number = Console.ReadLine();
        // int magic_num_con = int.Parse(magic_number);

        int userGuess = 0;
        while (userGuess != magicNumber)
        {
            Console.WriteLine($"Guess the magic number");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);


            if (userGuess > magicNumber)
            {
                Console.WriteLine($"Your guess is higher, try next!");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine($"Your guess is lower, try next!");
            }
            else
            {
                Console.WriteLine($"Wow!You guessed right!");
            }
        }
    }
}