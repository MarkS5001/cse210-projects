class Activity
{
    protected int _time; // Duration of activities
    private string _description; // Individual activity description
    private string _name; // Individual activity name
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
        _time = int.Parse(Console.ReadLine())*1000; // Time in milliseconds
    }
    public void EndActivity() // Ends activity
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name} activity.");
        Spinner();
    }
    public void Spinner() // Wait animation
    {
        for(int i = 0; i < 5; i++)
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
}