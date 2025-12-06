class Reception : Event
{
    private string _email;
    public Reception(string email, string type, string title, string description, string date, string time, string streetAddress, string city, string state, string country) : base(type,title, description, date, time, streetAddress, city, state, country)
    {
        _email = email;
    }
    public override string Full()
    {
        return base.Full()+$"\nRSVP @ {_email}";
    }
}