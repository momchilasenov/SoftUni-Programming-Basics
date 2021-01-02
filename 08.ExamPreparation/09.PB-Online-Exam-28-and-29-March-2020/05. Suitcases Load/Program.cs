using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int countSuitcases = 0;
            int loadedSuitcases = 0;

            while (command != "End")
            {
                double suitcaseVolume = double.Parse(command); //100
                countSuitcases++;

                if (countSuitcases % 3 == 0)
                {
                    suitcaseVolume += suitcaseVolume * 0.1;
                }
                trunkCapacity -= suitcaseVolume;
                
                if (trunkCapacity < 0)
                {
                    break;
                }
                loadedSuitcases++;           
                command = Console.ReadLine();
            }
            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {loadedSuitcases} suitcases loaded.");
        }
    }
}
