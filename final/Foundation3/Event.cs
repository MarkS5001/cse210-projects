class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address = new Address();
    public Event(string type, string title, string description, string date, string time, string streetAddress, string city, string state, string country)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address.SetAddress(streetAddress, city, state, country);
    }
    public string Standard()
    {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.GetAddress()}";
    }
    public string Short()
    {
        return $"{_type}\n{_title}\n{_date}";
    }
    public virtual string Full()
    {
        return Standard();
    }
}