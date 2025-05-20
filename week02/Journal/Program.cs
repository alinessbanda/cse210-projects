using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        RandomPromptGenerator promptGenerator = new RandomPromptGenerator();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Journal Menu ---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry added.");
                    break;

                case "2":
                    Console.WriteLine("\n--- Your Journal Entries ---");
                    journal.DisplayEntries();
                    break;

                case "3":
                    journal.WriteToFile();
                    break;

                case "4":
                    journal.ReadFromFile();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number 1-5.");
                    break;


            }
        }
    }
}