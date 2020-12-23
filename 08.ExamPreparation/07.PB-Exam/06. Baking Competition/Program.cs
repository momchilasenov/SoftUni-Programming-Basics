using System;
using System.Net;

namespace _06._Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfChefs = int.Parse(Console.ReadLine());
            double totalSweets = 0;
            double totalMoney = 0;

            for (int i = 1; i<=numberOfChefs; i++)
            {
                string name = Console.ReadLine();
                string cakeType = Console.ReadLine();

                int cookiesCount = 0;
                int cakesCount = 0;
                int wafflesCount = 0;

                while (cakeType!= "Stop baking!")
                {
                    int numberOfCakes = int.Parse(Console.ReadLine());
                    
                    if (cakeType == "cookies")
                    {
                        cookiesCount += numberOfCakes;
                    }
                    else if (cakeType == "cakes")
                    {
                        cakesCount += numberOfCakes;
                    }
                    else if (cakeType == "waffles")
                    {
                        wafflesCount += numberOfCakes;
                    }

                    cakeType = Console.ReadLine();
                }
                totalSweets += cookiesCount + cakesCount + wafflesCount;
                totalMoney += cookiesCount * 1.50 + cakesCount * 7.80 + wafflesCount * 2.30;
                Console.WriteLine($"{name} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");
            }

            Console.WriteLine($"All bakery sold: {totalSweets}");
            Console.WriteLine($"Total sum for charity: {totalMoney:f2} lv.");

        }
    }
}
