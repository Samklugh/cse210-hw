using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int userNumber = int.Parse(guess);
        int attempts = 0;
        while (userNumber != number)
        {
            if (userNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            attempts++;
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            userNumber = int.Parse(guess);
        }

        Console.WriteLine("Congratulations! You guessed the number in " + attempts + " attempts.");
    }
}