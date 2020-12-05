using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());

            double totalP1 = p1 * hoursMissing;
            double totalP2 = p2 * hoursMissing;
            double totalLitres = totalP1 + totalP2;

            if (totalLitres <= poolVolume)
            {
                double pFull = (totalLitres / poolVolume) * 100;
                double pipe1 = totalP1 / totalLitres * 100;
                double pipe2 = totalP2 / totalLitres * 100;
                Console.WriteLine($"The pool is {pFull:f2}% full. Pipe 1: {pipe1:f2}%.Pipe 2: {pipe2:f2}%.");
            }
            else
            {
                double difference = totalLitres - poolVolume;
                Console.WriteLine($"For {hoursMissing:f2} hours the pool overflows with {difference:f2} liters.");
            }
        }
    }
}
