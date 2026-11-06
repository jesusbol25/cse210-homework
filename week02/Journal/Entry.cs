
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText; 

    public void Display()
    {
        // everything in one line
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}