using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private static readonly Random _random = new Random();

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        _duration = GetDurationFromUser();
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        string[] frames = new string[] { "|", "/", "-", "\\" };
        int totalTicks = seconds * 4;
        for (int i = 0; i < totalTicks; i++)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected List<string> ShuffleList(List<string> items)
    {
        List<string> copy = new List<string>(items);
        for (int i = copy.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            string temp = copy[i];
            copy[i] = copy[j];
            copy[j] = temp;
        }

        return copy;
    }

    private int GetDurationFromUser()
    {
        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int seconds) && seconds > 0)
            {
                return seconds;
            }

            Console.WriteLine("Please enter a positive whole number.");
        }
    }
}
