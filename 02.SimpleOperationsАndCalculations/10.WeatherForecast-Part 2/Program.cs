using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Градуси Време
            //26.00 - 35.00   Hot
            //20.1 - 25.9 Warm
            //15.00 - 20.00   Mild
            //12.00 - 14.9    Cool
            //5.00 - 11.9 Cold

            double degrees = double.Parse(Console.ReadLine());

            if (degrees >= 5.00 && degrees <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (degrees >= 12.00 && degrees <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees >= 15.00 && degrees <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees >= 20.01 && degrees <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees >= 26.00 && degrees <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
