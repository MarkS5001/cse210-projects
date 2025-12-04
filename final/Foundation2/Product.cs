class Product
{
    private string _name;
    private string _id;
    private double _pricePer;
    private int _quantity;
    public Product(string name, string id, double pricePer, int quantity)
    {
        _name = name;
        _id = id;
        _pricePer = pricePer;
        _quantity = quantity;
    }
    public double TotalPrice()
    {
        return _pricePer * _quantity;
    }
    public string Getid()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}