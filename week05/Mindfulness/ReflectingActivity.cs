//I improved the program adding the capacity to avoid repeating questions in the reflecting activity. Now, once a question is asked, it will be removed from the list of available questions until all questions have been asked, at which point the list will reset. This ensures that users are presented with a variety of questions during their reflection session.

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

        List<string> unusedQuestions = new List<string>(_questions);
        while (DateTime.Now < endTime)
        {
            if (unusedQuestions.Count == 0) 
            {
                
                unusedQuestions = new List<string>(_questions);
            }
            int index = random.Next(unusedQuestions.Count);
            string question = unusedQuestions[index];
            unusedQuestions.RemoveAt(index);
            Console.WriteLine(question);
            ShowSpinner(10);
        }
        DisplayEndingMessage();
    }
}