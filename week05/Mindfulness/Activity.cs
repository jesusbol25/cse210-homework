

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    } 

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description); 
        Console.Write("How long, in seconds, would you like to do this activity? ");
        _duration = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner(5);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public int ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        return seconds;
    }
}