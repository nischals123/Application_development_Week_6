namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 3, 18, 20 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\nNumbers greater than 10:");
            ProcessNumbers(numbers, n => n > 10);
        }

        static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}