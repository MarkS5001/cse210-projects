// To exceed requirements, I created two other classes to load scriptures from a file
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Initialize variables for random scripture
        ReadFile file = new ReadFile();
        file.FileName("Scripture Bank.txt");
        file.GetFileContents();
        RandomList scriptureRandom = new RandomList();

        foreach (string currentLine in file.SendFileLines())
        {
            scriptureRandom.MakeList(currentLine.Split('~')[0], currentLine.Split('~')[1]);
        }

        // Initialize variables for loop, and memorization
        string quit = "";
        // Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        string text = scriptureRandom.RandomComponent()[1];
        string references = scriptureRandom.RandomComponent()[0];
        Scripture scripture = new Scripture(references, text);

        do
        {
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            if (Console.ReadLine() == "quit" || scripture.AllHidden() == "quit") // Check quit status
            {
                quit = "quit";
            }
            scripture.HideWord();
        } while (quit == "");
    }
}
