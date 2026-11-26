using System;
using homework;

class Program
{
    static void Main(string[] args)
    {
        // Create a MathAssignment object
        Assignment assignment = new Assignment("Jesus Bolivar", "Math");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Jesus Bolivar", "Algebra", "Section 5.2", "1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Create a WritingAssignment object
        WritingAssignment writingAssignment = new WritingAssignment("Jane Smith", "Essay", "The Importance of Education");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}