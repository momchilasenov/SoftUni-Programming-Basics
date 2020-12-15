using System;

namespace _02._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double lunchTime = breakDuration * 1* 1*1.0 / 8;
            double restTime = breakDuration * 1 * 1.0 / 4;
            double timeLeft = breakDuration - lunchTime - restTime; 

            if (timeLeft >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodeDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration-timeLeft)} more minutes.");
            }
        }
    }
}
