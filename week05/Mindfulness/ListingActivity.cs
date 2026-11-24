
using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base("Listing Activity",
            "This activity will help you reflect on the good things in your life.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are some personal strengths you have?",
            "Who have you helped recently?",
            "What are things that make you happy?",
            "What are some things you are grateful for?"
        };

        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(response))
            {
                _count++;
            }
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
    }
}
