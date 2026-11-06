using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Instancias el diario UNA SOLA VEZ aquí
        Journal journal = new Journal();
        string choice = "";

        // While loop to keep the program running until the user chooses to quit
        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Write a new journal entry
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string entryText = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = prompt;
                entry._entryText = entryText;

                // 4. CORREGIDO: Borrada la línea de new Journal()
                journal._entries.Add(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                // Load journal entries from a file
                Console.WriteLine("Enter the filename to load:");
                string filename = Console.ReadLine();
                filename = filename + ".json";
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                // Save journal entries to a file
                Console.WriteLine("Enter the filename to save:");
                string filename = Console.ReadLine();
                filename = filename + ".json";
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                // Quit the program
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                break;    
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}