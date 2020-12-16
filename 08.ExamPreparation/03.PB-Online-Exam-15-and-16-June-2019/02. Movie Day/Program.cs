using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForAction = int.Parse(Console.ReadLine());
            int numberOfScenes = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());

            double prep = 0.15 * timeForAction;

            double timeForShooting = numberOfScenes * sceneDuration;
            double totalTime = timeForShooting + prep; 

            if (totalTime <= timeForAction)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForAction - totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {totalTime - timeForAction} minutes.");
            }

        }
    }
}
