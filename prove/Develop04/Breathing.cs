class Breathing : Activity
{
    private int _waitTime = 3000; // Time to wait (milliSeconds)
    public Breathing(string name, string description) : base(name, description)
    {

    }
    public void CountDown()
    {
        for (int j = 3; j > 0; j--) // Countdown
            {
                Console.Write($"{j}");
                Thread.Sleep(1000);
                if (j == 1)
                {
                    Console.WriteLine("\b \b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
    }
    public void BreatheLoop() // Breathe activity logic
    {
        BeginActivity();
        Console.WriteLine("Get Ready...");
        Spinner();
        Console.WriteLine();

        for (int i = 0; i < _time; i += 6000) // Each loop takes 6 seconds 
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            CountDown();
            Console.Write("Breath out...");
            CountDown();
        }

        EndActivity();
    }
}