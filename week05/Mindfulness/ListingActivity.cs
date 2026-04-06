using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _shuffledPrompts;
    private int _promptIndex;

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _shuffledPrompts = ShuffleList(_prompts);
        _promptIndex = 0;
    }

    public void Run()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
    }

    private string GetRandomPrompt()
    {
        if (_promptIndex >= _shuffledPrompts.Count)
        {
            _shuffledPrompts = ShuffleList(_prompts);
            _promptIndex = 0;
        }

        return _shuffledPrompts[_promptIndex++];
    }
}
