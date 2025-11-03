class Program
{
    static void Main(string[] args)
    {
        Breathing breathe = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int _userChoice; // Keep track of user choice

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _userChoice = int.Parse(Console.ReadLine());

            if (_userChoice == 1)
            {
                breathe.BreatheLoop();
            }
            else if (_userChoice == 2)
            {
                reflection.StartReflection();
            }
            else if (_userChoice == 3)
            {
                listing.StartListing();
            }
        } while (_userChoice != 4);
    }
}