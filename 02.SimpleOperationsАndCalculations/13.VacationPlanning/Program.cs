using System;
using System.Security.Cryptography;

namespace VacationPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Calculate profit from order
            double puzzle = 2.60;
            double doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double orderProfit = puzzle * puzzles + dolls * doll + bears * bear + minions * minion + trucks * truck;

            // 2. Order >= 50
            double totalOrder = puzzles + dolls + bears + minions + trucks;

            if (totalOrder >= 50)
            {
                orderProfit = orderProfit * 0.75;
            }

            double profitAfterRent = orderProfit * 0.9;

            double diff = Math.Abs(profitAfterRent - tripPrice);

            if (profitAfterRent >= tripPrice)
            {
                Console.WriteLine($"Great go on vacation you have {diff:f2}");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {diff:f2} more");
            }
          
        }
    }
}
