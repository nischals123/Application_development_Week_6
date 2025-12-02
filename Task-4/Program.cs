using System;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squaredNumbers = numbers.Select(n => n * n);

        Console.WriteLine("Task 1: Squared Numbers:");
        foreach (var sq in squaredNumbers)
        {
            Console.WriteLine(sq);
        }

        var books = new[]
        {
            new { Title = "C# Programming", Price = 800.0 },
            new { Title = "Data Structures", Price = 1200.0 },
            new { Title = "AI Fundamentals", Price = 1500.0 },
            new { Title = "Database Systems", Price = 950.0 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("\nTask 2: Premium Books (Price > 1000):");
        foreach (var book in premiumBooks)
        {
            Console.WriteLine($"{book.Title} - Rs. {book.Price}");
        }

  
        List<string> students = new List<string>
        {
            "Sita", "Anita", "Ramesh", "Usha", "Kamal",
            "Bikash", "Manoj", "Prakash", "Sabin", "Hari"
        };

        var sortedStudents = students.OrderBy(s => s);

        Console.WriteLine("\nTask 3: Students Sorted Alphabetically:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}
