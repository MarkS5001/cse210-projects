class Outdoor : Event
{
    private string _weather;
    public Outdoor(string weather, string type, string title, string description, string date, string time, string streetAddress, string city, string state, string country) : base(type,title, description, date, time, streetAddress, city, state, country)
    {
        _weather = weather;
    }
    public override string Full()
    {
        return base.Full()+$"\nWeather Forecast: {_weather}";
    }
}