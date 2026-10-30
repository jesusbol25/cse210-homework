using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your percentage grade: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "";
        
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge 1 & 2: Determine the sign using the modulo operator
        string sign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Stretch Challenge 5: Handle the A+ exception
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        
        // Stretch Challenge 6: Handle the F+ and F- exceptions
        if (letter == "F")
        {
            sign = "";
        }

        // Stretch Challenge 2: Display both letter and sign in one print statement
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Core Requirement: Pass/Fail evaluation
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}