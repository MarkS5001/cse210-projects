class Customer
{
    private string _name;
    private Address _address = new Address();
    public void SetCustomer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address.SetAddress(streetAddress, city, state, country);
    }
    public bool US()
    {
        return _address.US();
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}