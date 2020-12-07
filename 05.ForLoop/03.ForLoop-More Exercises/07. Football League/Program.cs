using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numberOfFans = int.Parse(Console.ReadLine());
            double sectorAFans = 0;
            double sectorBFans = 0;
            double sectorVFans = 0;
            double sectorGFans = 0;
            double totalFans = 0;

            for (int i = 1; i <= numberOfFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                totalFans++;

                if (sector == 'A' || sector == 'B')
                {
                    if (sector == 'A')
                    {
                        sectorAFans++;
                    }
                    else
                    {
                        sectorBFans++;
                    }
                }
                else if (sector == 'V' || sector == 'G')
                {
                    if (sector == 'V')
                    {
                        sectorVFans++;
                    }
                    else
                    {
                        sectorGFans++;
                    }
                }
            }
            Console.WriteLine($"{sectorAFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorBFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorVFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{sectorGFans / numberOfFans * 100:f2}%");
            Console.WriteLine($"{totalFans / stadiumCapacity * 100:f2}%");
        }
    }
}
