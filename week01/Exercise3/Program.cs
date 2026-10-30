using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to the Magic Number Game!");
       
       // using random number generator to generate a random number between 1 and 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("I have selected a magic number between 1 and 100. Can you guess it?");

        while (userGuess != magicNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out userGuess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            attempts++;

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the magic number {magicNumber} in {attempts} attempts.");
            }
        }
    }
}