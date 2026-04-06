using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        int remaining = _duration;
        const int breathSeconds = 4;

        while (remaining > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            int inSeconds = remaining < breathSeconds ? remaining : breathSeconds;
            ShowCountDown(inSeconds);
            remaining -= inSeconds;

            if (remaining <= 0)
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Breathe out... ");
            int outSeconds = remaining < breathSeconds ? remaining : breathSeconds;
            ShowCountDown(outSeconds);
            remaining -= outSeconds;
        }

        Console.WriteLine();
    }
}
