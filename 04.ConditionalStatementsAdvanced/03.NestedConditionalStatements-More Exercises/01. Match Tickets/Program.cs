using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            double moneyForTransport = 0;
            double ticketPrice = 0;

            if (numberOfPeople >=1 && numberOfPeople <= 4)
            {
                moneyForTransport = budget * 0.75;
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                moneyForTransport = budget * 0.60;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                moneyForTransport = budget * 0.50;
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                moneyForTransport = budget * 0.40;
            }
            else if (numberOfPeople >= 50)
            {
                moneyForTransport = budget * 0.25;
            }

            double moneyLeft = budget - moneyForTransport;

            if (category == "Normal")
            {
                ticketPrice = 249.99;
            }
            else if (category == "VIP")
            {
                ticketPrice = 499.99;
            }

            double moneyForTickets = ticketPrice * numberOfPeople; 

            if (moneyForTickets <= moneyLeft)
            {
                Console.WriteLine($"Yes! You have {moneyLeft - moneyForTickets:f2} leva left.");
            }
            else if (moneyLeft < moneyForTickets)
            {
                Console.WriteLine($"Not enough money! You need {moneyForTickets - moneyLeft:f2} leva.");
            }

        }
    }
}
