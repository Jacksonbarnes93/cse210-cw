using System;

class Program
{
    static void Main(string[] args)
    {

        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("500 West Ave", "Denver", "CO", "USA");
        Address addr3 = new Address("89 Lakeside Rd", "Provo", "UT", "USA");
        
        Lecture lecture = new Lecture(
            "AI and the Future",
            "A deep dive into current AI technologies",
            "March 10, 2025",
            "5:00 PM",
            addr1,
            "Dr. Smith",
            150
        );

        Reception reception = new Reception(
            "Startup Night",
            "Meet local entrepreneurs and innovators",
            "April 2, 2025",
            "7:00 PM",
            addr2,
            "rsvp@eventscompany.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Spring Festival",
            "An outdoor celebration with food and music",
            "May 12, 2025",
            "11:00 AM",
            addr3,
            "Sunny with light breeze"
        );
        Event[] events = { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("== Full Details ==");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("=== Short Description ===");
            string eventType = ev.GetType().Name; 
            Console.WriteLine(ev.GetShortDescription(eventType));
            Console.WriteLine("-----------------------------\n");
        }
    }
}
