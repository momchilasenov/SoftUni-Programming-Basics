using System;
using System.Drawing;

namespace _04._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startingPoints = int.Parse(Console.ReadLine());
            int counter = 0;

            while (true)
            { 
                string sector = Console.ReadLine();
                counter++; //след като уцели сектор броим удар

                if (sector == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {counter} moves!");
                    break;
                }

                int points = int.Parse(Console.ReadLine());

                if (sector == "number section")
                {
                    startingPoints -= points;
                }
                else if (sector == "double ring")
                {
                    startingPoints -= 2 * points;
                }
                else if (sector == "triple ring")
                {
                    startingPoints -= 3 * points;
                }

                if (startingPoints == 0)
                {
                    Console.WriteLine($"Congratulations! You won the game in {counter} moves!");
                    break; // задължително break-ваш цикъла
                }
                else if (startingPoints < 0)
                {
                    Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(startingPoints)}.");
                    break;
                }

            }



        }
    }
}
