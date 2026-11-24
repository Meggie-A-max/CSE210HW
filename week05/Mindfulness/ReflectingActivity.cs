
using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
        : base("Reflection Activity",
            "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you overcame a challenge.",
            "Think of a time when you made someone smile."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel during this experience?",
            "What did you learn about yourself?",
            "What made this experience difficult?",
            "How can you use what you learned in the future?",
            "Who helped you during this experience?",
            "What would you do differently next time?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.Write($"\n> {question} ");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
