using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to the Magic Number Game!");
        Console.Write("What is your magic number? : ");
        int magicNumber = int.Parse(Console.ReadLine());

        Console.Write("What is your guess? : ");
        int guess = int.Parse(Console.ReadLine());

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher!");
        }
        else
        {
            Console.WriteLine("Lower!");
        }
    }
}