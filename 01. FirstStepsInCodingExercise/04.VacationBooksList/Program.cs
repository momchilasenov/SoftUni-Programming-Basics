using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            //Calculations
            double totalTime = pages / pagesPerHour;
            double hoursNeeded = totalTime / days;

            Console.WriteLine(hoursNeeded);

        }
    }
}
