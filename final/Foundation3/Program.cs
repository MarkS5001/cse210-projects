using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        Lecture lecture = new Lecture("Bob", 100, "Lecture", "Bob's Great Fishing Adventure", "Come hear about Bob's most recent fishing trip from the 'Pond Behind Walmart'.", "12-6-2025", "11:00am", "34 1st st", "Rexburg", "ID", "USA");
        Reception reception = new Reception("Th!$I$MyReal3ma!1@email.com", "Reception", "Bill's Wedding Reception", "Come join us for Bill and Diane's wedding celebration", "12-8-2025", "6:00pm", "10000000 1000th Ave", "Flagstaff", "AZ", "USA");
        Outdoor outdoor = new Outdoor("Mostly Foggy", "Outdoor", "The Great Frog Migration", "Come join us as we gather to witness the great frog migration that blesses our town every 8 years!", "12-9-2025", "4:00am", "55 Froggy DR", "Grenouille", "Paris", "FR");

        _events.Add(lecture);
        _events.Add(reception);
        _events.Add(outdoor);

        foreach(Event currentEvent in _events)
        {
            Console.WriteLine("\n");
            Console.WriteLine(currentEvent.Standard());
            Console.WriteLine("\n");
            Console.WriteLine(currentEvent.Short());
            Console.WriteLine("\n");
            Console.WriteLine(currentEvent.Full());
            Console.WriteLine("\n");
        }
    }
}