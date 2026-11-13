using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, text);

        string userInput = ""; 

        while (userInput != "quit" && scripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); 

            //instruct the user to press enter to continue or type "quit" to exit
            Console.WriteLine("Press enter to continue or type 'quit' to exit.");
            userInput = Console.ReadLine();
            

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        
            if (scripture.IsCompletelyHidden() == true)
         {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
         }         
        }
    }
}