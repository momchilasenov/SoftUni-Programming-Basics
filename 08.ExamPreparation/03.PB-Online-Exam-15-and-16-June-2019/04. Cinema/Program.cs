using System;

namespace _04._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int cinemaCapacity = int.Parse(Console.ReadLine());
            int peopleCount = 0;
            double currentRevenue = 0;
            double totalRevenue = 0;
            int numberOfPeople = 0;
            string peopleEnteringTheCinema = "";

            while (true)
            {
                peopleEnteringTheCinema = Console.ReadLine();
                

                if (peopleEnteringTheCinema == "Movie time!")
                {
                    
                    break;

                }

                numberOfPeople = int.Parse(peopleEnteringTheCinema);

                if (numberOfPeople > cinemaCapacity)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }

                currentRevenue = numberOfPeople * 5;
                if (numberOfPeople% 3 == 0)
                {
                    currentRevenue -= 5;
                }
                totalRevenue += currentRevenue;
                

                cinemaCapacity -= numberOfPeople;


            }
            if (peopleEnteringTheCinema == "Movie time!")
            {
                Console.WriteLine($"There are {cinemaCapacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {totalRevenue} lv.");
        }
    }
}
