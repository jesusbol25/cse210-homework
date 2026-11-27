

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you are grateful for.",
        "List as many personal strengths as you can.",
        "List as many people who have positively influenced your life.",
        "List as many accomplishments you are proud of.",
        "List as many things that bring you joy."
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void StartListingActivity()
    {
        DisplayStartingMessage();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        Console.WriteLine();
        ShowCountdown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                count++;
            }
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
    }
}