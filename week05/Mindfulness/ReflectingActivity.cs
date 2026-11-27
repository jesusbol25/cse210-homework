

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you achieved a personal goal.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you made a positive impact on someone else's life."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this experience?",
        "How did this experience change your perspective?",
        "What strengths did you demonstrate during this experience?",
        "How can you apply what you learned from this experience in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void StartReflectingActivity()
    {
        DisplayStartingMessage();
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(5);
        Console.WriteLine("Now, consider the following questions:");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}