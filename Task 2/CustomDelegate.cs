using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CustomDelegate
    {
        //question1
        public delegate int Calculate(int a, int b);

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;

        //question2
        public delegate double DiscountStrategy(double price);

        public static double FestivalDiscount(double price) => price - (price * 0.20);
        public static double SeasonalDiscount(double price) => price - (price * 0.10);
        public static double NoDiscount(double price) => price;

        //question2.1
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);


    }
}