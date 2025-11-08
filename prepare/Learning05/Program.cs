class Program
{
    static void Main(string[] args)
    {
        // Console.Clear();

        Square square = new Square("orange", 5);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("red", 5, 10);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("yellow", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        // List<Shape> shapes = new List<Shape>();
        // shapes.Add(square);
        // shapes.Add(rectangle);
        // shapes.Add(circle);
        List<Shape> shapes = new List<Shape> {square, rectangle, circle};
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}