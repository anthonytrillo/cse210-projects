using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
            Console.WriteLine("Excelent!.");
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            Console.WriteLine("This is a good name.");
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            Console.WriteLine("This is an average name.");
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            Console.WriteLine("This is a below average name.");
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else
        {
            Console.WriteLine("Oops, try your best next time!");
        }
    }
}