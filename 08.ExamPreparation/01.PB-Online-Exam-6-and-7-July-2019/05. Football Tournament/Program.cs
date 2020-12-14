using System;

namespace _05._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTeam = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int points = 0;
            int totalPoints = 0;
            int totalGames = 0;

            int wins = 0;
            int draws = 0;
            int losses = 0;

            if (gamesPlayed == 0)
            {
                Console.WriteLine($"{nameOfTeam} hasn't played any games during this season.");
                return;
            }

            for (int i = 1; i<= gamesPlayed; i++)
            {
                char result = char.Parse(Console.ReadLine());

                if (result == 'W')
                {
                    points = 3;
                    wins++;
                }
                else if (result == 'D')
                {
                    points = 1;
                    draws++;
                }
                else if (result == 'L')
                {
                    points = 0;
                    losses++;
                }
                totalPoints += points;
                totalGames = wins + draws + losses;

            }
            Console.WriteLine($"{nameOfTeam} has won {totalPoints} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {wins}");
            Console.WriteLine($"## D: {draws}");
            Console.WriteLine($"## L: {losses}");
            Console.WriteLine($"Win rate: {wins*1.0/totalGames*100:f2}%");
   
        }
    }
}
