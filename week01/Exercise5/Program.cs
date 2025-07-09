using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        int userNumber;

        Console.WriteLine("Please enter your favorite number:");
        string userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {squaredNumber}.");
    }
}