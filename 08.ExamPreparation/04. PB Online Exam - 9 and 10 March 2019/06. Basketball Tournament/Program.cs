using System;
using System.Security.Cryptography;

namespace _06._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();
            double totalGames = 0;
            double gamesWon = 0;
            double gamesLost = 0;


            
            while (tournamentName != "End of tournaments")
            {
                int numberOfGames = int.Parse(Console.ReadLine());
                int gameCounter = 0; 

                for (int i = 1; i <= numberOfGames; i++) 
                {
                    totalGames++;
                    gameCounter++;
                    int desiPoints = int.Parse(Console.ReadLine());
                    int opponentsPoints = int.Parse(Console.ReadLine());

                    if (desiPoints > opponentsPoints)
                    {
                        Console.WriteLine($"Game {gameCounter} of tournament {tournamentName}: win with {desiPoints - opponentsPoints} points.");
                        gamesWon++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {gameCounter} of tournament {tournamentName}: lost with {opponentsPoints - desiPoints} points.");
                        gamesLost++;
                    }

                    

                }

                tournamentName = Console.ReadLine();
            }
            Console.WriteLine($"{gamesWon / totalGames * 100:f2}% matches win");
            Console.WriteLine($"{gamesLost / totalGames * 100:f2}% matches lost");

        }
    }
}
