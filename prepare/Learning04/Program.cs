class Program
{
    static void Main(string[] args)
    {
        Assignment bill = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(bill.GetSummary());

        MathAssignment bob = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(bob.GetSummary());
        Console.WriteLine(bob.GetHomeworkList());

        WritingAssignment joel = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(joel.GetSummary());
        Console.WriteLine(joel.GetWritingInformation());
    }
}