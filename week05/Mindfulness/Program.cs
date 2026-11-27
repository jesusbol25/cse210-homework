using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an activity (1-4): ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartBreathingActivity();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.StartReflectingActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    System.Threading.Thread.Sleep(2000);
                    break;
            }
        }
    }
}