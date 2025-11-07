class Program // To Exceed requirements I added functionality to keep track of the program's use
{
    static void Main(string[] args)
    {
        // Initialize all needed variables
        Breathing breathe = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Reflection reflection = new Reflection("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        int _userChoice; // Keep track of user choice
        ReadWriteFile file = new ReadWriteFile();
        file.FileName("Activity Tracker.txt");

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Display statistics");
            Console.WriteLine("  5. Quit");
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
            else if (_userChoice == 4)
            {
                Console.Clear();
                file.GetFileContents();
                file.DisplayFileContents();
                Console.WriteLine();
                Console.WriteLine("Press enter to quit");
                Console.ReadLine();
            }
        } while (_userChoice != 5);
    }
}