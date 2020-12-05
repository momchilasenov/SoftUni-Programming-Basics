using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int workDays = 365 - restDays;

            double totalPLayTime = restDays * 127 + workDays * 63;
            const int playNorm = 30000;

            double difference = Math.Abs(totalPLayTime - playNorm);
            double hours = Math.Floor(difference / 60);
            double minutes = Math.Floor(difference % 60);

            if (totalPLayTime > playNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours:f0} hours and {minutes:f0} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours:f0} hours and {minutes:f0} minutes less for play");
            }

        }
    }
}
