class Reflection : Activity
{
    private List<string> _prompt = new List<string> { "1", "2", "3" }; // List for prompts
    private List<string> _questions = new List<string> { "1", "2", "3" }; // List for questions
    public Reflection(string name, string description) : base(name, description)
    {

    }
    public string GetPrompt() // Get random prompt
    {
        Random random = new Random();
        int promptIndex = random.Next(0, _prompt.Count);
        
        return _prompt[promptIndex];
    }
    public string GetQuestion() // Get random question
    {

    }
    public void StartReflection() // Reflection activity logic
    {
        
    }
}