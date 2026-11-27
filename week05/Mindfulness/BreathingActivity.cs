

public class BreathingActivity : Activity
{
    public BreathingActivity()
    
        :base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
    {   
    }

    public void StartBreathingActivity()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}