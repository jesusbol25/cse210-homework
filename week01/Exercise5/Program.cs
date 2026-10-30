using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Llamamos a la función de bienvenida
        DisplayWelcome();

        // 2. Llamamos a la función del nombre y guardamos el resultado en una variable
        string userName = PromptUserName();

        // 3. Llamamos a la función del número y guardamos el resultado
        int userNumber = PromptUserNumber();

        // 4. Pasamos el número a la función que lo eleva al cuadrado y guardamos el resultado
        int squaredNumber = SquareNumber(userNumber);

        // 5. Pasamos el nombre y el número al cuadrado a la función final para imprimirlos
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}