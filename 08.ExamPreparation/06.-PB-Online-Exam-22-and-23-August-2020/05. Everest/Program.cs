using System;

namespace _05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string restOrNo = Console.ReadLine();

            double heightReached = 5364;

            int dayCounter = 1;

            while (restOrNo != "END")
            {
                if (restOrNo == "Yes")
                {
                    dayCounter++;
                }
                if (dayCounter > 5)
                {
                    
                    break;
                }

                int metersClimbed = int.Parse(Console.ReadLine());
                heightReached += metersClimbed;
                if (heightReached >= 8848)
                {
                    break;
                }

                restOrNo = Console.ReadLine();
            }
            if (heightReached >= 8848)
            {
                Console.WriteLine($"Goal reached for {dayCounter} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine($"{heightReached}");
            }
        }
    }
}
