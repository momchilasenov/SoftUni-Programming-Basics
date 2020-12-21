using System;

namespace _02._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lengthOfTunnel = double.Parse(Console.ReadLine());
            int timePer100Meters = int.Parse(Console.ReadLine());

            double timeToBeat = minutes * 60 + seconds;
            double timeInTunnel = lengthOfTunnel / 100;
            double time = timePer100Meters * timeInTunnel;

            double delay = (lengthOfTunnel / 120) * 2.5;
            double finalTime = time - delay;

            if (finalTime <= timeToBeat)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {finalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {finalTime - timeToBeat:f3} second slower.");
            }

        }
    }
}
