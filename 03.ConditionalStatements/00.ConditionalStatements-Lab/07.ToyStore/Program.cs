using System;

namespace _07.ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Calculate the order profit 
            double puzzle = 2.60;
            int doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            int truck = 2;

            //Console Input
            double holidayPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalProfit = puzzle * numberOfPuzzles + doll * numberOfDolls + bear * numberOfBears + minion * numberOfMinions + truck * numberOfTrucks;

            //2. calculate number of items ordered
            int itemsOrdered = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            //3. IF order >= 50 -> 25% discount 
            if (itemsOrdered >= 50)
            {
                totalProfit = totalProfit * 0.75;
            }

            //4. 10% of profit goes to rent 
            double profitAfterRent = totalProfit * 0.9;
            //5. calculate IF the money will be enough for holiday
            double endResult = (profitAfterRent - holidayPrice);

            if (profitAfterRent >= holidayPrice)
            {
                Console.WriteLine($"Yes! {endResult:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {endResult:f2} lv needed.");
            }

            // Another algorithm to solve the problem
            //if (endResult >= 0)
            //{
            //    Console.WriteLine($"Yes! {endResult:f2} lv left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! {Math.Abs(endResult):f2} lv needed.");
            //}

        }
    }
}
