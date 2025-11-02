using System;

class Program
{
    int _userChoice; // Keep track of user choice
    public void Menu() // Provide menu
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine("Select a choice from the menu: ");
        _userChoice = int.Parse(Console.ReadLine());
    }
    public void choice() // Do choice
    {
        if (_userChoice == 1)
        {
            breath
        }
        else if (_userChoice == 2) {
            reflection
        }
        else if (_userChoice == 3)
        {
            lisiting
        }
        else if (_userChoice == 4)
        {
            
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    }
}