using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");

        int number = -1;

        while (number != 0)
        {
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            Console.WriteLine($"Enter number: {number}");

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        Console.WriteLine($"The sum is {numbers.Sum()}.");
        Console.WriteLine($"The average of the numbers is {numbers.Average()}.");
        Console.WriteLine($"The largest number is {numbers.Max()}.");
        Console.WriteLine($"The smallest number is {numbers.Min()}.");
    }
}