using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double pricePerTicket = double.Parse(Console.ReadLine());
            int percentageForCinema = int.Parse(Console.ReadLine());

            double profitPerDay = tickets * pricePerTicket;
            double totalProfit = days * profitPerDay;
            totalProfit -= totalProfit * percentageForCinema*1.0/100;

            Console.WriteLine($"The profit from the movie {movieName} is {totalProfit:f2} lv.");
        }
    }
}
