using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usdcourse = 1.79549;
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * usdcourse;

            Console.WriteLine($"{bgn:f2}");
        }
    }
}
