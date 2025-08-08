using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity act = new BreathingActivity();
                act.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity act = new ReflectingActivity();
                act.Run();
            }
            else if (choice == "3")
            {
                ListingActivity act = new ListingActivity();
                act.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
                Thread.Sleep(2000);
            }

            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }
    }
}