using System;
using System.Data;

namespace _04._Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
           
            double price = 0;
            double totalPrice = 0;
            int productCounter = 0;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "Stop")
                {
                    break;
                }
                productCounter++;

                price = double.Parse(Console.ReadLine());
                if (productCounter % 3 == 0 && productCounter != 0)
                {
                    price *= 0.5;
                }

                totalPrice += price;


                if (price > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {price - budget:f2} leva!");
                    break;
                }
                budget -= price;


            }
            if (budget >= price)
            {
                Console.WriteLine($"You bought {productCounter} products for {totalPrice:f2} leva.");

            }
        }
    }
}
