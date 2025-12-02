
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // question1
            CustomDelegate.Calculate calc = CustomDelegate.Add;
            Console.WriteLine("Addition: " + calc(10, 5));

            calc = CustomDelegate.Subtract;
            Console.WriteLine("Subtraction: " + calc(10, 5));


            Console.WriteLine("\n Discount Strategy Example \n");

            double originalPrice = 1000;

            // passing methods one by one
            Console.WriteLine("Festival Discount Final Price: " +
                CustomDelegate.CalculateFinalPrice(originalPrice, CustomDelegate.FestivalDiscount));

            Console.WriteLine("Seasonal Discount Final Price: " +
                CustomDelegate.CalculateFinalPrice(originalPrice, CustomDelegate.SeasonalDiscount));

            Console.WriteLine("No Discount Final Price: " +
                CustomDelegate.CalculateFinalPrice(originalPrice, CustomDelegate.NoDiscount));


            // using lambda for 30% discount
            Console.WriteLine("\nLambda 30% Discount Final Price: " +
                CustomDelegate.CalculateFinalPrice(originalPrice, price => price - (price * 0.30)));

        }
    }
}