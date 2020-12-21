using System;

namespace _01._Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double tennisRacketPrice = double.Parse(Console.ReadLine());
            int numberOfRackets = int.Parse(Console.ReadLine());
            int sneakerPairs = int.Parse(Console.ReadLine());

            double totalRackets = numberOfRackets * tennisRacketPrice;
            double totalSneakers = sneakerPairs * tennisRacketPrice * 1 / 6;
            double accessories = (totalRackets + totalSneakers) * 0.2;
            double total = totalRackets + totalSneakers + accessories;

            double priceForDjokovic = total * 1 / 8;
            double priceForSponsors = total * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceForDjokovic)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceForSponsors)}");

        }
    }
}
