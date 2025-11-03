using System.Xml;

class Reflection : Activity
{
    private List<string> _prompts = new List<string> { "1", "2", "3" }; // List for prompts
    private List<string> _questions = new List<string> { "1", "2", "3" }; // List for questions
    private Random random = new Random(); // Random seed for random prompt, and question
    private int _index; // Stores random index for prompt, and question
    private string _currentPrompt; // Stores current prompt
    private string _currentQuestion; // Stores current question
    private DateTime _startTime; // Stores start time for loop
    private DateTime _futureTime; // Stores end time for loop
    private int _count; // Stores count of questions answered
    public Reflection(string name, string description) : base(name, description)
    {

    }
    public void GetPrompt() // Get random prompt
    {
        _index = random.Next(0, _prompts.Count);
        _currentPrompt = _prompts[_index];
        _prompts.RemoveAt(_index);
    }
    public void GetQuestion() // Get random question
    {
        _index = random.Next(0, _questions.Count);
        _currentQuestion = _questions[_index];
        _questions.RemoveAt(_index);
    }
    public void StartReflection() // Reflection activity logic
    {
        GetPrompt(); // Gets prompt to reflect on
        BeginActivity();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {_currentPrompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        Console.WriteLine("You may begin in: ");
        CountDown(5);
        Console.Clear();

        // Initialize variables for loop
        _count = 0;
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_time);

        while (_startTime < _futureTime)
        {
            GetQuestion();
            Console.WriteLine($"> {_currentQuestion}");
            Spinner();
            _count++;
            Console.WriteLine();
        }

        EndActivity();
    }
}