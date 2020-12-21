using System;

namespace _06._Vet_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfHours = int.Parse(Console.ReadLine());

            double price = 0;

            double allDaysPrice = 0;
           
            for (int days = 1; days<=numberOfDays; days++)
            {

                double totalDailyPrice = 0;

                for (int hours = 1; hours<= numberOfHours; hours++)
                {
                    if (days % 2 != 0) 
                    {
                        if (hours%2 == 0)  
                        {
                            price = 1.25;
                        }
                        else 
                        {
                            price = 1.00;
                        }
                    }
                    else if (days %2 == 0) 
                    {
                        if (hours %2 != 0) 
                        {
                            price = 2.50;
                        }
                        else
                        {
                            price = 1.00;
                        }
                    }
                    totalDailyPrice += price;
                    allDaysPrice += price;
                }
                Console.WriteLine($"Day: {days} - {totalDailyPrice:f2} leva");
            }
            Console.WriteLine($"Total: {allDaysPrice:f2} leva");
        }
    }
}
