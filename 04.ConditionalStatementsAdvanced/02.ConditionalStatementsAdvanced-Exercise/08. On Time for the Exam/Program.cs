using Microsoft.VisualBasic.CompilerServices;
using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinute = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minutes = 0;

            examMinute += examHour * 60; //получаваш общо часа на exam в минути
            arriveMinute += arriveHour * 60; //получаваш общо часа на arrive в минути

            if (arriveMinute > examMinute)
            {
                Console.WriteLine("Late");
                difference = arriveMinute - examMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arriveMinute < examMinute - 30)
            {
                Console.WriteLine("Early");
                difference = examMinute - arriveMinute;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                difference = examMinute - arriveMinute;
                if (arriveHour == examHour)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
        }
    }
}
