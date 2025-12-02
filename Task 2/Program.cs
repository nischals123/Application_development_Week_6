
class Program
{
    static void Main(string[] args)
    {
        Discount obj = new Discount();

        Discount.Calculate calcAdd = obj.Add;
        Discount.Calculate calcSub = obj.Subtract;

        Console.WriteLine("Add: " + calcAdd(10, 5));
        Console.WriteLine("Subtract: " + calcSub(10, 5));

        Discount.DiscountStrategy fest = obj.FestivalDiscount;
        Discount.DiscountStrategy seas = obj.SeasonalDiscount;
        Discount.DiscountStrategy none = obj.NoDiscount;

        double price = 1000;

        Console.WriteLine("Festival Discount Price: " + fest(price));
        Console.WriteLine("Seasonal Discount Price: " + seas(price));
        Console.WriteLine("No Discount Price: " + none(price));
    }
}
