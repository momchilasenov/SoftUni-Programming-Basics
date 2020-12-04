using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHeight = double.Parse(Console.ReadLine());
            double wallLength = double.Parse(Console.ReadLine());
            double roofHeight = double.Parse(Console.ReadLine());

            //Стените
            double doorArea = 1.2 * 2;
            double windowsArea = 1.5 * 1.5;

            double sideWallArea = houseHeight * wallLength;
            double totalSideWalls = sideWallArea * 2 - 2 * windowsArea;

            double frontWallArea = houseHeight * houseHeight;
            double totalFrontWalls = frontWallArea * 2 - doorArea;
            double totalWalls = totalFrontWalls + totalSideWalls;
            double greenPaint = totalWalls / 3.4;

            //Покривът
            double sides = (houseHeight * wallLength) * 2;
            double triangles = 2 * (houseHeight * roofHeight / 2);
            double totalRoof = sides + triangles;
            double redPaint = totalRoof / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
