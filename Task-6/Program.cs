using System;

class Program
{
    static void Main(string[] args)
    {
        List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Ram", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new TourBooking { CustomerName = "Sita", Destination = "Bangkok", Price = 25000, DurationInDay = 5, IsInternational = true },
            new TourBooking { CustomerName = "Gita", Destination = "Dubai", Price = 50000, DurationInDay = 4, IsInternational = true },
            new TourBooking { CustomerName = "Hari", Destination = "Chitwan", Price = 12000, DurationInDay = 6, IsInternational = false },
            new TourBooking { CustomerName = "Krishna", Destination = "KTM Tour", Price = 9500, DurationInDay = 2, IsInternational = false }
        };

        var filtered = bookings
            .Where(b => b.Price > 10000 && b.DurationInDay > 4);

        var transformed = filtered
            .Select(b => new
            {
                b.CustomerName,
                b.Destination,
                Category = b.IsInternational ? "International" : "Domestic",
                b.Price
            });

        var sorted = transformed
            .OrderBy(t => t.Category)  
            .ThenBy(t => t.Price);

        Console.WriteLine("=== Filtered, Transformed & Sorted Tour Summary ===\n");

        foreach (var item in sorted)
        {
            Console.WriteLine($"Customer: {item.CustomerName}");
            Console.WriteLine($"Destination: {item.Destination}");
            Console.WriteLine($"Category: {item.Category}");
            Console.WriteLine($"Price: Rs. {item.Price}");
            Console.WriteLine("-------------------------------------");
        }
    }
}
