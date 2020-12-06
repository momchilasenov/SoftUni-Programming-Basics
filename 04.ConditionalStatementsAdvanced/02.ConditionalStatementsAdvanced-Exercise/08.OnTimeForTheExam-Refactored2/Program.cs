using System;

namespace _08.OnTimeForTheExam_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //По-кратко решение на проблема

            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinute;
            int totalArriveMinutes = arriveHour * 60 + arriveMinute;

            if (totalArriveMinutes > totalExamMinutes)
            {
                Console.WriteLine("Late");
            }
            else if (totalExamMinutes - totalArriveMinutes <= 30)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Early");
            }

            int result = Math.Abs(totalArriveMinutes - totalExamMinutes);

            if (totalExamMinutes - totalArriveMinutes > 0)
            {
                if (result < 60)
                {
                    Console.WriteLine($"{result} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{result / 60}:{result % 60:d2} hours before the start");
                }
            }
            else if (totalArriveMinutes - totalExamMinutes > 0)
            {
                if (result < 60)
                {
                    Console.WriteLine($"{result} minutes after the start");
                }
                else
                {
                    Console.WriteLine($"{result / 60}:{result % 60:d2} hours after the start");
                }   
            }

        }
    }
}
