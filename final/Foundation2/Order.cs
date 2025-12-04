class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    public Order(string name, string streetAddress, string city, string state, string country)
    {
        _customer.SetCustomer(name, streetAddress, city, state, country);
    }
    public void AddProduct(string name, string id, double pricePer, int quantity)
    {
        Product currentProduct = new Product(name, id, pricePer, quantity);
        _products.Add(currentProduct);
    }
    public double TotalCost()
    {
        double currentCost = 0;
        
        foreach(Product currentProduct in _products)
        {
            currentCost += currentProduct.TotalPrice();
        }
        if (_customer.US())
        {
            currentCost += 5;
        }
        else
        {
            currentCost += 35;
        }
        return Math.Round(currentCost, 2);
    }
    public string PackingLabel()
    {
        string currentLabel = "";
        foreach(Product currentProduct in _products)
        {
            currentLabel += $"Product Name: {currentProduct.GetName()} ; Product ID: {currentProduct.Getid()} ; Quantity: {currentProduct.GetQuantity()}\n";
        }
        return currentLabel;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}