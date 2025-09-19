using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromtUserBirthYear(out int birthYear) {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int num) {
        return num * num;
    }

    static void DisplayResult() {
        string name = PromptUserName();
        int num = PromptUserNumber();
        PromtUserBirthYear(out int birth);

        int currentYear = 2025;
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(num)}");
        Console.WriteLine($"{name}, you will turn {currentYear - birth} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }
}
// Welcome to the program!
// Please enter your name: Brother Burton
// Please enter your favorite number: 42
// Please enter the year you were born: 1990
// Brother Burton, the square of your number is 1764
// Brother Burton, you will turn 35 this year.