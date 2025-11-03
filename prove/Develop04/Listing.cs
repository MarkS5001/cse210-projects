class Listing : Activity
{
    private List<string> _prompts = new List<string> { "1", "2", "3" }; // List for prompts
    private int _itemCounter;
    private int _index; // Stores random index for prompt, and question
    private string _currentPrompt; // Stores current prompt
    private Random _random = new Random(); // Random seed for random prompt, and question
    private DateTime _startTime; // Stores start time for loop
    private DateTime _futureTime; // Stores end time for loop
    public Listing(string name, string description) : base(name, description)
    {

    }
    public void GetPrompt() // Gets random prompts
    {
        _index = _random.Next(0, _prompts.Count);
        _currentPrompt = _prompts[_index];
        _prompts.RemoveAt(_index);
    }
    public void StartListing() // Listing activity logic
    {
        GetPrompt();

        BeginActivity();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{_currentPrompt}---");
        Console.WriteLine("You may begin in: ");
        CountDown(5);
        
        // Initialize variables for loop
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_time);

        while (DateTime.Now < _futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _itemCounter++;
        }
        Console.WriteLine($"You listed {_itemCounter} items!");
        EndActivity();
    }
}