class Bike : Activity
{
    private double _speed;
    public Bike(double speed, string date, double length) : base(date, length, "Bike")
    {
        _speed = speed;
    }
    public override double Distance()
    {
        return _speed*_length/60;
    }
    public override double Speed()
    {
        return _speed;
    }
}