using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "NPTU";
        job2._company = "US Navy";
        job2._startYear = 2025;
        job2._endYear = 2031;
        job2.Display();

        Console.WriteLine();

        Resume resume = new Resume();
        resume._name = "Bill";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}