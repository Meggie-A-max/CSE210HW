
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> activityHistory = new List<string>();

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityHistory.Add(
                        $"Breathing Activity - {breathing.GetDuration()} seconds");
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    activityHistory.Add(
                        $"Reflection Activity - {reflecting.GetDuration()} seconds");
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityHistory.Add(
                        $"Listing Activity - {listing.GetDuration()} seconds");
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid option. Please select 1, 2, 3, or 4.");
                    ThreadPause();
                    break;
            }
        }

        // Extra feature: Display a history of completed activities.
        // This helps users keep track of their mindfulness sessions.
        Console.WriteLine("\nMindfulness Session History");
        Console.WriteLine("-------------------------");

        if (activityHistory.Count == 0)
        {
            Console.WriteLine("No activities completed yet.");
        }
        else
        {
            foreach (string activity in activityHistory)
            {
                Console.WriteLine(activity);
            }

            Console.WriteLine($"\nTotal activities completed: {activityHistory.Count}");
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program!");
    }

    static void ThreadPause()
    {
        System.Threading.Thread.Sleep(1500);
    }
}
