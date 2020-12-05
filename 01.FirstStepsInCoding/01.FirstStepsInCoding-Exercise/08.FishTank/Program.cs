using System;

namespace _08.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = length * width * height;
            double volumeInLtrs = volume * 0.001;
            double percentageTaken = percentage * 0.01;
            double letersNeeded = volumeInLtrs * (1 - percentageTaken);

            Console.WriteLine(letersNeeded);
        }
    }
}
