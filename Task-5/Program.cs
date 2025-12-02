using System;
class Program
{
    static void Main(string[] args)
    {
        List<CashierSales> cashierSales = new List<CashierSales>
        {
            new CashierSales { CashierName = "A", Sales = 5000 },
            new CashierSales { CashierName = "B", Sales = 7000 },
            new CashierSales { CashierName = "C", Sales = 4000 },
            new CashierSales { CashierName = "D", Sales = 6500 }
        };

        int totalCashiers = cashierSales.Count();
        double totalSales = cashierSales.Sum(c => c.Sales);
        double highestSale = cashierSales.Max(c => c.Sales);
        double lowestSale = cashierSales.Min(c => c.Sales);
        double averageSale = cashierSales.Average(c => c.Sales);

        Console.WriteLine("=== Task 5.1: Aggregation ===");
        Console.WriteLine($"Total Cashiers: {totalCashiers}");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Highest Sale: {highestSale}");
        Console.WriteLine($"Lowest Sale: {lowestSale}");
        Console.WriteLine($"Average Sale: {averageSale}");

        List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Ram", Age = 20 },
            new Applicant { Name = "Sita", Age = 17 },
            new Applicant { Name = "Gopal", Age = 19 },
            new Applicant { Name = "Hari", Age = 22 }
        };

        bool anyUnder18 = applicants.Any(a => a.Age < 18);
        bool allAbove16 = applicants.All(a => a.Age > 16);

        Console.WriteLine("\n=== Task 5.2: Quantifier ===");
        Console.WriteLine($"Any applicant under 18? {anyUnder18}");
        Console.WriteLine($"All applicants above 16? {allAbove16}");

        List<Song> songs = new List<Song>
        {
            new Song { Title = "Song 1", DurationSec = 180 },
            new Song { Title = "Song 2", DurationSec = 250 },
            new Song { Title = "Song 3", DurationSec = 430 },
            new Song { Title = "Song 4", DurationSec = 700 }
        };

        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationSec > 240);
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSec > 600);

        Console.WriteLine("\n=== Task 5.3: Element Operators ===");
        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First song above 4 minutes: {firstAbove4Min.Title}");

        if (firstAbove10Min != null)
            Console.WriteLine($"Song above 10 minutes: {firstAbove10Min.Title}");
        else
            Console.WriteLine("No song longer than 10 minutes found.");
    }
}
