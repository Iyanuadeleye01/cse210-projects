using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string choice = "";
        while (choice != "5")
        {

            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine("Enter your response:");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                
                    newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added.\n");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to save");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);

            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the filename to load from");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("Invalid option,try again");
            }

           
        }
    }
}