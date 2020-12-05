using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int flowerA = int.Parse(Console.ReadLine()); 
            int flowerB = int.Parse(Console.ReadLine()); 
            int flowerC = int.Parse(Console.ReadLine()); 
            int flowerD = int.Parse(Console.ReadLine());
            double presentGift = double.Parse(Console.ReadLine());

            const double flowerAPrice = 3.25;
            const double flowerBPrice = 4;
            const double flowerCPrice = 3.5;
            const double flowerDPrice = 8;

            double totalOrderPrice = flowerA * flowerAPrice + flowerB * flowerBPrice + flowerC * flowerCPrice + flowerD * flowerDPrice;

            totalOrderPrice -= totalOrderPrice * 0.05;

            if (totalOrderPrice >= presentGift)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalOrderPrice-presentGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentGift-totalOrderPrice)} leva.");
            }
        }
    }
}
