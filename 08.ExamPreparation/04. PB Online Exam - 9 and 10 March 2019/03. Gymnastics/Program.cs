using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string playingTool = Console.ReadLine();

            double difficulty = 0;
            double performance = 0;

            if (playingTool == "ribbon")
            {
                if (country == "Russia")
                {
                    difficulty = 9.1;
                    performance = 9.4;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.6;
                    performance = 9.4;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.2;
                    performance = 9.5;
                }
            }
            else if (playingTool == "hoop")
            {
                if (country == "Russia")
                {
                    difficulty = 9.3;
                    performance = 9.8;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.550;
                    performance = 9.750;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.450;
                    performance = 9.350;
                }
            }
            else if (playingTool == "rope")
            {
                if (country == "Russia")
                {
                    difficulty = 9.6;
                    performance = 9.0;
                }
                else if (country == "Bulgaria")
                {
                    difficulty = 9.5;
                    performance = 9.4;
                }
                else if (country == "Italy")
                {
                    difficulty = 9.7;
                    performance = 9.150;
                }
            }
            double total = difficulty + performance;
            double percentage = ((20 - total) / 20) * 100;

            Console.WriteLine($"The team of {country} get {total:f3} on {playingTool}.");
            Console.WriteLine($"{percentage:f2}%");
        }
    }
}
