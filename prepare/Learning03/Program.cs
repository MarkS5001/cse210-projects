using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bob");
        Fraction bob = new Fraction();
        bob.GetTop();
        bob.GetBottom();
        bob.SetTop(6);
        Console.WriteLine(bob.GetFractionString());
        Console.WriteLine(bob.GetDecimalValue());

        Console.WriteLine("jim");
        Fraction jim = new Fraction(6);
        jim.GetTop();
        jim.GetBottom();
        jim.SetBottom(2);
        Console.WriteLine(jim.GetFractionString());
        Console.WriteLine(jim.GetDecimalValue());

        Console.WriteLine("ty");
        Fraction ty = new Fraction(6, 7);
        ty.GetTop();
        ty.GetBottom();
        Console.WriteLine(ty.GetFractionString());
        Console.WriteLine(ty.GetDecimalValue());
    }
}