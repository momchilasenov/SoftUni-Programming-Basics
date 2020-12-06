using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniourCyclers = int.Parse(Console.ReadLine());
            int seniorCyclers = int.Parse(Console.ReadLine());
            string trackType = Console.ReadLine();

            double juniourPrice = 0;
            double seniorPrice = 0;
            double totalPrice = 0;

            if (trackType == "trail")
            {
                juniourPrice = 5.50;
                seniorPrice = 7;
            }
            else if (trackType == "cross-country")
            {
                juniourPrice = 8;
                seniorPrice = 9.5;
                if (juniourCyclers + seniorCyclers >= 50)
                {
                    juniourPrice -= juniourPrice * 0.25;
                    seniorPrice -= seniorPrice * 0.25;

                }
            }
            else if (trackType == "downhill")
            {
                juniourPrice = 12.25;
                seniorPrice = 13.75;
            }
            else
            {
                juniourPrice = 20;
                seniorPrice = 21.50;
            }

            totalPrice = juniourCyclers * juniourPrice + seniorCyclers * seniorPrice;
            totalPrice -= totalPrice * 0.05; //expenses

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
