using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    Console.WriteLine("\nPress Enter to return to the main menu.");
                    Console.ReadLine();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    Console.WriteLine("\nPress Enter to return to the main menu.");
                    Console.ReadLine();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    Console.WriteLine("\nPress Enter to return to the main menu.");
                    Console.ReadLine();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("\nGoodbye!");
                    Thread.Sleep(1000);
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
