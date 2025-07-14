using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job
    {
      _company = "Google",
      _jobTitle = "Software Engineer",
      _startYear = 2015,
      _endYear = 2023
    };

    Job job2 = new Job
    {
      _company = "Meta",
      _jobTitle = "Technical Lead",
      _startYear = 2023,
      _endYear = 2024
    };

    Resume myResume = new Resume
    {
      _name = "Anthony Trillo"
    };

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);
    myResume.Display();
  }
}