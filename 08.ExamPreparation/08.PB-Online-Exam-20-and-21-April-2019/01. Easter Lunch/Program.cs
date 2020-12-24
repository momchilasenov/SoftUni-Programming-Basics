using System;
using System.Net;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());
            int eggCrates = int.Parse(Console.ReadLine());
            int cookiesInKg = int.Parse(Console.ReadLine());

            double totalEasterBreads = easterBreads * 3.20;
            double totalEggs = eggCrates * 4.35;
            double totalCookies = cookiesInKg * 5.40;
            double paintForEggs = eggCrates * 12 * 0.15;

            double total = totalEasterBreads + totalCookies + totalEggs + paintForEggs;
            Console.WriteLine($"{total:f2}");

        }
    }
}
