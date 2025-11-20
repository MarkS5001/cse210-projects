class BadGoal : Goal
{
    public BadGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
    public BadGoal()
    {
        
    }
    public override void GetGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal? ");
        _pointValue = -1 * System.Math.Abs(int.Parse(Console.ReadLine()));
    }
    public override string SaveGoal()
    {
        return $"BadGoal~{_name}~{_description}~{_pointValue}";
    }
}