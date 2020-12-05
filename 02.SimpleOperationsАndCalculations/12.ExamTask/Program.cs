using System;

namespace ExamTask
{
    class Program
    {
        static void Main(string[] args)
        {

            double puzzle = 2.60;
            int doll = 3;
            double bear = 4.10;
            double minion = 8.20;
            int truck = 2;

            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalProfit = puzzles * puzzle + dolls * doll + bears * bear + minions * minion + trucks * truck;

            int totalOrder = puzzles + dolls + bears + minions + trucks;

            if (totalOrder >= 50)
            {
                totalProfit = totalProfit * 0.75;
            }

            totalProfit = totalProfit * 0.9;

            double diff = Math.Abs(holidayPrice - totalProfit);

            if (totalProfit >= holidayPrice)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed");
            }








        }
    }
}
