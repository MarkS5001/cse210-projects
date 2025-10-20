using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize needed variables
        string quit = "";
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        do
        {
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            if(Console.ReadLine()=="quit" || scripture.AllHidden() == "quit") // Check quit status
            {
                quit = "quit";
            }
            scripture.HideWord();
        } while (quit == "");
    }
}
