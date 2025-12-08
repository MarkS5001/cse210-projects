public abstract class Activity
{
    private string _date;
    protected double _length;
    private string _name;
    public Activity(string date, double length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }
    public abstract double Distance();
    public abstract double Speed();
    public double Pace()
    {
        return 60/Speed();
    }
    public string Summary()
    {
        return $"{_date} {_name} ({_length} min): Distance: {Math.Round(Distance(),2)} km, Speed: {Math.Round(Speed(),2)} kph, Pace: {Math.Round(Pace(),2)} min per km";
    }
}