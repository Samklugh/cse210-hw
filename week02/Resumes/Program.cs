using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Company";
        job1._startYear = 2020;
        job1._endYear = 2022;

        resume._name = "John Doe";
        resume._jobs.Add(job1);

        Job job2 = new Job();
        job2._jobTitle = "Senior Software Engineer";
        job2._company = "Another Tech Company";
        job2._startYear = 2022;
        job2._endYear = 2024;

        resume._jobs.Add(job2);

        // resume.Display();
        Console.WriteLine("***********************************");
        Console.WriteLine();

        job1.Display();
        Console.WriteLine();

        job2.Display();
        Console.WriteLine();

        Console.WriteLine("***********************************");
    }
}