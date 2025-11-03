class Breathing : Activity
{
    private int _waitTime = 3000; // Time to wait (milliSeconds)
    public Breathing(string name, string description) : base(name, description)
    {

    }
    public void BreatheLoop() // Breathe activity logic
    {
        BeginActivity();

        for (int i = 0; i < _time; i += 6000) // Each loop takes 6 seconds 
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            CountDown(3);
            Console.Write("Breath out...");
            CountDown(3);
        }

        EndActivity();
    }
}