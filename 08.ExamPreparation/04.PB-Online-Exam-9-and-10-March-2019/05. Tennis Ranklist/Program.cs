using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double pointsWon = 0;
            double wonTournaments = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                string stageReached = Console.ReadLine();

                if (stageReached == "W")
                {
                    startingPoints += 2000;
                    pointsWon += 2000;
                    wonTournaments++;
                }
                else if (stageReached == "F")
                {
                    startingPoints += 1200;
                    pointsWon += 1200;
                }
                else if (stageReached == "SF")
                {
                    startingPoints += 720;
                    pointsWon += 720;
                }

            }
            double averagePoints = Math.Floor(pointsWon / numberOfTournaments);

            Console.WriteLine($"Final points: {startingPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{(wonTournaments / numberOfTournaments) * 100:f2}%");




        }
    }
}
