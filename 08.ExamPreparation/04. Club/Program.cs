using System;

namespace _04._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desiredProfit = double.Parse(Console.ReadLine());
            double totalProfit = 0;

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                int numberOfCoctails = int.Parse(Console.ReadLine());
                int priceOfCoctail = command.Length;
                double totalForCoctail = numberOfCoctails * priceOfCoctail;

                if (totalForCoctail % 2 != 0)
                {
                    totalForCoctail -= totalForCoctail * 0.25;
                }
                totalProfit += totalForCoctail;

                if (totalProfit >= desiredProfit)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "Party!")
            {
                Console.WriteLine($"We need {desiredProfit - totalProfit:f2} leva more.");

            }
            Console.WriteLine($"Club income - {totalProfit:f2} leva.");
        }
    }
}
