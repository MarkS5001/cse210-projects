class Swimming : Activity
{
    private double _laps; // Needs to be a double for the distance calculation
    public Swimming(double laps, string date, double length) : base(date, length, "Swimming")
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps*50/1000;
    }
    public override double Speed()
    {
        return Distance()/_length;
    }
}