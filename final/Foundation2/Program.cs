class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Bob", "34 1st st", "Rexburg", "ID", "USA");
        order1.AddProduct("Fish", "12-1", 50.65, 4);
        order1.AddProduct("Fish Tank", "12-5", 100.99, 1);
        order1.AddProduct("Fish Food", "12-2", 12.99, 2);
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.TotalCost());

        Console.WriteLine("\n\n");

        Order order2 = new Order("Joel", "43 2nd st", "Calgary", "AB", "CA");
        order2.AddProduct("On The Shoulders of Giants by Stephen Hawking", "3-14", 29.99, 1);
        order2.AddProduct("Starry Bookmark", "6-02", 1.99, 3);
        order2.AddProduct("Oxford Dictionary", "2-99", 49.99, 1);
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.TotalCost());
    }
}