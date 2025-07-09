using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magic Number Game!");
        Console.WriteLine("I have selected a magic number between 1 and 100.");

        int magicNumber = Random.Shared.Next(1, 101);
        Console.WriteLine($"{magicNumber}");

        int userGuess = 0;

        while (userGuess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);

            if (userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("Your guess is out of range. Please try again.");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Higuer.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}