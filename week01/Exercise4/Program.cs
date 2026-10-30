using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int userNumber = -1;

        
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Variables for calculus 
        int sum = 0;
        int max = numbers[0]; 

        // Calculate the sum and find the largest number
        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        // Calculate the average
        float average = ((float)sum) / numbers.Count;

        // Print the results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}