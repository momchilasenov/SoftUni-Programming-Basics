using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double transportPrice = 0;

            if (distance < 20)
            {
                if (dayOrNight == "day")
                {
                    transportPrice = 0.7 + distance * 0.79;
                }
                else if (dayOrNight == "night")
                {
                    transportPrice = 0.7 + distance * 0.90;
                }
            }
            else if (distance >= 20 && distance < 100)
            {
                transportPrice = distance * 0.09;
            }
            else if (distance >= 100)
            {
                transportPrice = distance * 0.06;
            }

            Console.WriteLine($"{transportPrice:f2}");
        }
    }
}
