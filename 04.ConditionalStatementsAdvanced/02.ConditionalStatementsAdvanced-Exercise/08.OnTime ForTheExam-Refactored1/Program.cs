using System;

namespace _08.OnTime_ForTheExam_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //това е мое самостоятелно решение след като се научих как се решава задачата
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int totalExamMinute = examHour * 60 + examMinute;
            int totalArriveMinute = arriveHour * 60 + arriveMinute;

            int difference = 0;
            int hour = 0;
            int minute = 0;

            if (totalArriveMinute > totalExamMinute)
            {
                Console.WriteLine("Late");
                difference = totalArriveMinute - totalExamMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minute = difference % 60;
                    Console.WriteLine($"{hour}:{minute:d2} hours after the start");
                }
                
            }
            else if (totalArriveMinute < totalExamMinute - 30)
            {
                Console.WriteLine("Early");
                difference = totalExamMinute - totalArriveMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minute = difference % 60;
                    Console.WriteLine($"{hour}:{minute:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = totalExamMinute - totalArriveMinute;
                if (difference <= 30 && difference > 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            


        }
    }
}
