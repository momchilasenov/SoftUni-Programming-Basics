using System;

namespace _05.Time__15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            
            int minutesPlus15 = minutes + 15;

            if (minutesPlus15 > 60)
            {
                hours = hours + 1;
                minutesPlus15 = minutesPlus15 - 60;
            }
            
            if (hours > 23)
            {
                hours = 0;
            }
            
            if (minutesPlus15 < 10)
            {
                Console.WriteLine($"{hours}:0{minutesPlus15}");
            }
            
            else
            {
                Console.WriteLine($"{hours}:{minutesPlus15}");
            }

            ////РЕШЕНИЕ 2
            //// Input
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //// Calculations
            //minutes += 15;

            //if (minutes >= 60)
            //{
            //    minutes -= 60;
            //    hours += 1;
            //}
            //if (hours >= 24)
            //{
            //    hours = 0
            //}
            ////Output
            //Console.WriteLine($"{hours}:{minutes:d2}");

        }
    }
}