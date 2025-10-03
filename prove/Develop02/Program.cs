using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        // Create prompt bank
        List<string> promptBank = new List<string>
        {
            "What did you talk about at dinner?",
            "What did you see today that you thought about after it happened?",
            "What intriguing thing did you read today?",
            "If money was no object, what would you have done today?",
            "What color did you see less of today?"
        };

        //Create random seed for random prompt generation
        Random randomGenerator = new Random();

        // Initialize journal
        Journal journal = new Journal();

        // Initialize variable names
        string filename;
        int promptNumber;
        string currentPrompt;
        string response;
        Entry currentEntry;
        DateTime today;
        int choice;

        do
        {
            //Get choice
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine()); //Read choice from user, and convert to integer


            //Deal with choices

            if (choice == 1)
            {
                // Get date
                today = DateTime.Today;

                // Display prompt
                promptNumber = randomGenerator.Next(0, promptBank.Count);
                currentPrompt = promptBank[promptNumber];
                Console.WriteLine(currentPrompt);

                // Get response
                response = Console.ReadLine();

                // Save entry information
                currentEntry = new Entry();
                currentEntry._date = today.ToString("MM-dd-yyyy");
                currentEntry._prompt = currentPrompt;
                currentEntry._response = response;
                journal._entries.Add(currentEntry);
            }

            else if (choice == 2)
            {
                journal.Display();
            }

            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                //NOT DONE
            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                filename = Console.ReadLine();
                //NOT DONE
            }

        } while (choice != 5);
    }
}