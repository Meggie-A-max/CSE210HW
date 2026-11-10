
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity feature: The program randomly selects one scripture
        // from a library of three scriptures each time it starts.

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding."
            ),

            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son."
            ),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            )
        };

        Random random = new Random();
        int selectedIndex = random.Next(scriptureLibrary.Count);

        Scripture scripture = scriptureLibrary[selectedIndex];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine();
        Console.WriteLine("Thank you for using Scripture Memorizer!");
    }
}
