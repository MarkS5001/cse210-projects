using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(10, "08 Dec 2025", 40);
        Bike bike = new Bike(10, "09 Dec 2025", 20);
        Swimming swimming = new Swimming(10, "10 Dec 2025", 60);

        List<Activity> _activities = new List<Activity>{running, bike, swimming};

        foreach(Activity currentActivity in _activities)
        {
            Console.WriteLine(currentActivity.Summary());
        }
    }
}