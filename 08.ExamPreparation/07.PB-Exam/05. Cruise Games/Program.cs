using System;

namespace _05._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());
            int volleyCounter = 0;
            int tennisCounter = 0;
            int badminCounter = 0;

            double volleyPoints = 0;
            double tennisPoints = 0;
            double badminPoints = 0;

            double totalPoints = 0;

            for (int i = 1; i <= gamesPlayed; i++)
            {
                string gameName = Console.ReadLine();
                int points = int.Parse(Console.ReadLine());

                if (gameName == "volleyball")
                {
                    volleyPoints += points + points * 0.07;
                    volleyCounter++;
                }
                else if (gameName == "tennis")
                {
                    tennisPoints += points + points * 0.05;
                    tennisCounter++;
                }
                else if (gameName == "badminton")
                {
                    badminPoints += points + points * 0.02;
                    badminCounter++;
                }
                totalPoints = Math.Floor(volleyPoints + tennisPoints + badminPoints);
            }
            double averageVolley = Math.Floor(volleyPoints / volleyCounter);
            double averageTennis = Math.Floor(tennisPoints / tennisCounter);
            double averageBadmin = Math.Floor(badminPoints / badminCounter);

            bool volley = averageVolley >= 75;
            bool badmin = averageBadmin >= 75;
            bool tennis = averageTennis >= 75;

            if (volley && badmin && tennis)
            {
                Console.WriteLine($"Congratulations, {nameOfPlayer}! You won the cruise games with {totalPoints} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {nameOfPlayer}, you lost. Your points are only {totalPoints}.");
            }
        }
    }
}
