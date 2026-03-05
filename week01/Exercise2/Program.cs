using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your test score: ");
        string scores = Console.ReadLine();
        int exam_score = int.Parse(scores);

        int passGrade = 70;
        string letter = "";

        if (exam_score >= 90)
            if (exam_score >= 95)
            {
                letter = "A+";
            }

            else if (exam_score == 90)
            {
                letter = "A";
            }
            else
            {
                letter = "A-";
            }

        else if (exam_score >= 80)

            if (exam_score >= 85)
            {
                letter = "B+";
            }
            else if (exam_score == 80)
            {
                letter = "B";
            }
            else
            {
                letter = "B-";
            }

        else if (exam_score >= 70)
            if (exam_score >= 75)
            {
                letter = "C+";
            }
            else if (exam_score == 70)
            {
                letter = "C";
            }
            else
            {
                letter = "C-";
            }
        else if (exam_score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (exam_score < passGrade)
        {
            Console.WriteLine("You did not pass the exam.");
        }
        else
        {
            Console.WriteLine($"Congratulations! You passed the exam with a grade of {letter}.");
        }
    }
}