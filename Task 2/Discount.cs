public class Discount
{
    public delegate int Calculate(int a, int b);

    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;

    public delegate double DiscountStrategy(double price);

    public double FestivalDiscount(double price) => price * 0.80;   // 20% off
    public double SeasonalDiscount(double price) => price * 0.90;   // 10% off
    public double NoDiscount(double price) => price;                // no discount
}
