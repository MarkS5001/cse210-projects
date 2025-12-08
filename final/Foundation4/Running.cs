class Running : Activity
{
    private double _distance;
    public Running(double distance, string date, double length) : base(date, length, "Running")
    {
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    public override double Speed()
    {
        return _distance/_length * 60;
    }
}