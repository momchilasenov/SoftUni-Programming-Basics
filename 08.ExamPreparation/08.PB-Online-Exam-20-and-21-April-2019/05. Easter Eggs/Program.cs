using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int paintedEggs = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            string maxColour = "";

            for (int i = 1; i <= paintedEggs; i++)
            {
                string eggColour = Console.ReadLine();

                if (eggColour == "red")
                {
                    redEggs++;
                }
                else if (eggColour == "orange")
                {
                    orangeEggs++;
                }
                else if (eggColour == "blue")
                {
                    blueEggs++;
                }
                else if (eggColour == "green")
                {
                    greenEggs++;
                }

            }

            int maxEggs = redEggs;
            maxColour = "red";

            if (orangeEggs > maxEggs)
            {
                maxEggs = orangeEggs;
                maxColour = "orange";
            }
            if (blueEggs > maxEggs)
            {
                maxEggs = blueEggs;
                maxColour = "blue";
            }
            if (greenEggs > maxEggs)
            {
                maxEggs = greenEggs;
                maxColour = "green";
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColour}");
        }
    }
}
