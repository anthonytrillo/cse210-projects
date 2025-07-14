using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Application!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();

        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            switch (choice)
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    string entry = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.Write("Enter filename to load entries: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadEntries(loadFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to save entries: ");
                    string filename = Console.ReadLine();
                    journal.SaveEntries(filename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            if (running)
            {
                Console.Write("What would you like to do next? ");
                choice = Console.ReadLine();
            }
        }
    }
}