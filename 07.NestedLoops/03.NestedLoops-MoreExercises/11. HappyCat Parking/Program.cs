using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());
            double price = 0;
            double total = 0;

            for (int day=1; day<=numberOfDays; day++)
            {
                double sum = 0;
                for (int hour=1; hour<=hoursPerDay; hour++)
                {
                    if (day % 2 == 0 && hour%2!=0)
                    {
                        price = 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        price = 1.25;
                    }
                    else
                    {
                        price = 1;
                    }
                    sum += price;
                                      
                }
                total += sum;
                Console.WriteLine($"Day: {day} - {sum:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
