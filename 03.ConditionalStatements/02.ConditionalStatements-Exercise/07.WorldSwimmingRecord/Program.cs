using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            // въвеждаме рекордът в секунди който трябва да подобри
            // разстояние в метри 
            // време в секунди за което плува 1м 
            double record = double.Parse(Console.ReadLine());
            double distaneInM = double.Parse(Console.ReadLine());
            double timePerM = double.Parse(Console.ReadLine());

            // изчисляваме времето на Иван // разстояние в м * време за 1 м
            double timeIvan = distaneInM * timePerM;

            // от разстоянието в метри изчисляваме колко отразъка по 15 м има (разстояние % 15 = брой отрязъци
            // забавянето = броят отрязъци * 12,5 секунди забавяне (закръгляме към Math.Floor
            double sections = Math.Floor(distaneInM / 15);
            double delay = sections * 12.5;

            // времето на Иван + забавяне = общо време
            double totalTime = timeIvan + delay;
                        
            // ако е успял да го подобри
            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            // ако не е успял
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime-record:f2} seconds slower."); 
            }
            

        }
    }
}
