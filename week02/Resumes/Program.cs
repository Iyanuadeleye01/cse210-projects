using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._comapany = "Microworld";
        job1._jobTitle = "Analyst";
        job1._startYear = 2025;
        job1._endYear = 2028;

        Job job2 = new Job();
        job2._comapany = "Emax";
        job2._jobTitle = "Engineer";
        job2._startYear = 2024;
        job2._endYear = 2029;

        Resume resume = new Resume();
        resume._name = "Iyanu Adeleye";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
        

        
    }
}