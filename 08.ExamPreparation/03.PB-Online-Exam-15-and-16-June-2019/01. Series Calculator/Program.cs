using System;

namespace _01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int numberOfSeasons = int.Parse(Console.ReadLine());
            int numberOfEpisodes = int.Parse(Console.ReadLine());
            double episodeDuration = double.Parse(Console.ReadLine());

            double commercials = episodeDuration * 0.2;

            double totalDuration = episodeDuration + commercials;

            double specialEpisodes = numberOfSeasons * 10;

            double totalTimeForSeries = totalDuration * numberOfSeasons * numberOfEpisodes + specialEpisodes;

            Console.WriteLine($"Total time needed to watch the {seriesName} series is {totalTimeForSeries} minutes.");
        }
    }
}
