using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double distaneInM = double.Parse(Console.ReadLine());
            double timePerM = double.Parse(Console.ReadLine());
            
            double timeIvan = distaneInM * timePerM;

            double sections = Math.Floor(distaneInM / 15);
            double delay = sections * 12.5;

            double totalTime = timeIvan + delay;
                        
            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime-record:f2} seconds slower."); 
            }
            

        }
    }
}
