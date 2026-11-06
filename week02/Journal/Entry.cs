
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText; 

    public void Display()
    {
        // Todo en una sola línea y sin el guion al principio
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }
}