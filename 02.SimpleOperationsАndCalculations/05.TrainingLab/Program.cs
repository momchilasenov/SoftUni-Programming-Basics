using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()); // length 
            double h = double.Parse(Console.ReadLine()); // width

            double rows = Math.Floor(((h * 100) - 100) / 70);
            double columns = Math.Floor(w * 100 / 120);
            double workStations = rows * columns - 3;
            Console.WriteLine($"{workStations:f0}");


            //НЕ РАБОТИ
            //double lengthInCm = w * 100;
            //double widthInCm = h * 100;

            //double corridorWidth = 100;

            //if (widthInCm >= 300 && lengthInCm >= widthInCm)
            //{
            //    if (lengthInCm >= widthInCm && lengthInCm <= 10000)
            //    {
            //        double widthWithoutCorridor = widthInCm - corridorWidth;
            //        double numberOfDesksInARow = Math.Round(widthWithoutCorridor / 70);
            //        double numberOfDesksInAColumn = Math.Round(lengthInCm / 120);

            //        double totalPlaces = numberOfDesksInAColumn * numberOfDesksInARow - 3;
            //        Console.WriteLine(totalPlaces);
            //    }

            //}

        }
    }
}
