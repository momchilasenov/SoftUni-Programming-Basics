using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearlyFeeForBasketball = int.Parse(Console.ReadLine());

            double sneakers = yearlyFeeForBasketball * 0.6;
            double clothing = sneakers - sneakers * 0.2;
            double ball = clothing * 0.25;
            double accessories = ball * 0.2;

            double total = yearlyFeeForBasketball + sneakers + clothing + ball + accessories;

            Console.WriteLine($"{total:f2}");
        }
    }
}
