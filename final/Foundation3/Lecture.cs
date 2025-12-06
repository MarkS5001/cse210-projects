class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, string type, string title, string description, string date, string time, string streetAddress, string city, string state, string country) : base(type,title, description, date, time, streetAddress, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string Full()
    {
        return base.Full()+$"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}