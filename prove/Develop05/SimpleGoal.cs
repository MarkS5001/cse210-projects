class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue, string completed) : base(name, description, pointValue)
    {
        _completed = completed;
    }
    public SimpleGoal()
    {
        
    }
    public override void IsCompleted()
    {
        _completed = "X";
    }
    public override int RecordEvent()
    {
        IsCompleted();
        return base.RecordEvent();
    }
    public override string SaveGoal()
    {
        return $"SimpleGoal~{_name}~{_description}~{_pointValue}~{_completed}";
    }
}