using System;

class Program
{
    static void Main(string[] args)
    {
        var eventAddress1 = new Address("789 Park Ave", "Cityville", "CA", "USA");
        var eventAddress2 = new Address("101 Garden St", "Townsville", "Stateville", "Canada");
        var eventAddress3 = new Address("456 Sky Blvd", "Mountain City", "NY", "USA");


        var lectureEvent = new Lecture("Tech Talk", "Exciting technology updates", DateTime.Now.AddDays(10), new TimeSpan(14, 0, 0), eventAddress1, "John Doe", 100);
        var receptionEvent = new Reception("Networking Mixer", "Connect and mingle with professionals", DateTime.Now.AddDays(20), new TimeSpan(18, 30, 0), eventAddress2, "rsvp@example.com");
        var outdoorEvent = new OutdoorGathering("Summer Picnic", "Fun in the sun", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), eventAddress3, "Sunny day with a slight breeze");


        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine();
    }
}