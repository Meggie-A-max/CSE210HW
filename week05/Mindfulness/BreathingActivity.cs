
using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountDown(4);

            if (DateTime.Now < endTime)
            {
                Console.Write("\nBreathe out...");
                ShowCountDown(4);
            }
        }

        DisplayEndingMessage();
    }
}
