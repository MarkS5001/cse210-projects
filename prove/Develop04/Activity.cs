class Activity
{
    protected int _time; // Duration of activities
    private string _description; // Individual activity description
    private string _name; // Individual activity name
    ReadWriteFile file = new ReadWriteFile("Activity Tracker.txt");
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void BeginActivity() // Begins activity
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine()); // Time in seconds
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner();
    }
    public void EndActivity() // Ends activity
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} activity.");
        Spinner();
        // file.GetFileContents();
        file.SaveContents(_name, _time);
        // file.ExportContents();
    }
    public void Spinner() // Wait animation
    {
        for (int i = 0; i < 2; i++)
        {
            Console.Write("-"); // Display character
            Thread.Sleep(500); // Wait time (milliSeconds)
            Console.Write("\b \b"); // Delete character

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void CountDown(int length)
    {
        for (int j = length; j > 0; j--) // Countdown
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                if (j == 1)
                {
                    Console.WriteLine("\b \b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
    }
}