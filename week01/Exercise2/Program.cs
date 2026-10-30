using System;

class Program
{
    static void Main(string[] args)
    {
         int A = 90;
         int B = 80;
         int c = 70; 
         int D = 60;
         int F = 60;
        Console.Write("Please enter your percentage grade: ");
        string percenUser = Console.ReadLine();
        int grade = int.Parse(percenUser);

        if (grade >= A)
        {
            Console.WriteLine("Congratulations! You're approved and your grade is A");
        }
        else if (grade >= B)
        {
            Console.WriteLine("Congratulations! You're approved and your grade is B");
        }
        else if (grade >= c)
        {
            Console.WriteLine("Congratulations! You're approved and your grade is C");
        }
        else if (grade >= D)
        {
            Console.WriteLine("Sorry, you're not approved and your grade is D");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }
    }
}