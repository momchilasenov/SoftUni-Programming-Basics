using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            const int volleyballWeekends = 48;

            string typeOfYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());

            double playsAtHome = weekendsAtHome;

            double sofiaPlays = (volleyballWeekends - weekendsAtHome)*0.75;

            double holidayPlays = (holidays*1.0*2)/3;

            double totalPlays = sofiaPlays + holidayPlays + playsAtHome;

            if (typeOfYear == "leap")
            {
                totalPlays += totalPlays * 0.15;
            }

            Console.WriteLine(Math.Floor(totalPlays));


        }
    }
}
