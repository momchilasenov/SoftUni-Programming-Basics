using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = timePerMeter * distanceInMeters;

            double timesDelayed = Math.Floor(distanceInMeters / 50);
            double totalDelay = timesDelayed * 30;

            double finalTime = totalTime + totalDelay;

            if (finalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {finalTime:f2} seconds.");
            }
            else
            {
                double difference = finalTime - record;
                Console.WriteLine($"No! He was {difference:f2} seconds slower.");
            }

        }
    }
}
