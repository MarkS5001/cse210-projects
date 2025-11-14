class ChecklistGoal : Goal
{
    private int _bonusValue;
    private int _timesCompleted;
    private int _targetCompletion;
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int timesCompleted, int targetCompletion) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesCompleted = timesCompleted;
        _targetCompletion = targetCompletion;       
    }
    public ChecklistGoal()
    {
        
    }
    public override void GetGoal()
    {
        // Console.WriteLine("What is the name of your goal? ");
        // _name = Console.ReadLine();

        // Console.WriteLine("What is a short description of it? ");
        // _description = Console.ReadLine();

        // Console.WriteLine("What is the amount of points associated with this goal? ");
        // _pointValue = int.Parse(Console.ReadLine());

        base.GetGoal();

        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _targetCompletion = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonusValue = int.Parse(Console.ReadLine());
    }
    public override void IsCompleted()
    {
        if (_timesCompleted == _targetCompletion)
        {
            _completed = "X";
        }
    }
    public override int RecordEvent()
    {
        _timesCompleted++;
    
        IsCompleted();

        if (_completed == "X")
        {
            return _bonusValue+_pointValue;
        }
        else
        {
            return base.RecordEvent();
        }
    }
    public override string SaveGoal()
    {
        return $"ChecklistGoal~{_name}~{_description}~{_pointValue}~{_bonusValue}~{_targetCompletion}~{_timesCompleted}";
    }
}