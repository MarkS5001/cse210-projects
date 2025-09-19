using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int addedNumber = 1;
        while (addedNumber != 0)
        {
            Console.Write("Enter Number: ");
            addedNumber = int.Parse(Console.ReadLine());
            if (addedNumber != 0)
            {
                numbers.Add(addedNumber);
            }
            
        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}