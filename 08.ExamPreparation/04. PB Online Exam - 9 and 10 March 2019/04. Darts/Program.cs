using System;
using System.Data;
using System.Drawing;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            double totalPoints = 301;
            int successfulShots = 0;
            int unsuccessfulShots = 0;
            int pointsPerShot = 0;

            string command = Console.ReadLine();


            while (command != "Retire")
            {
                int points = int.Parse(Console.ReadLine()); 

                if (command == "Triple")
                {
                    pointsPerShot = points * 3;
                    totalPoints -= pointsPerShot;
                    successfulShots++;
                }
                else if (command == "Double")
                {
                    pointsPerShot = points * 2;
                    totalPoints -= pointsPerShot;
                    successfulShots++;
                }
                else if (command == "Single")
                {
                    pointsPerShot = points;
                    totalPoints -= pointsPerShot;
                    successfulShots++; //10 - 13 = -3 => 
                }

                if (totalPoints < 0)
                {
                    successfulShots--;
                    unsuccessfulShots++;
                    totalPoints = totalPoints + pointsPerShot;
                }

                if (totalPoints == 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "Retire")
            {
                Console.WriteLine($"{player} retired after {unsuccessfulShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{player} won the leg with {successfulShots} shots.");
            }
            
        }
    }
}
