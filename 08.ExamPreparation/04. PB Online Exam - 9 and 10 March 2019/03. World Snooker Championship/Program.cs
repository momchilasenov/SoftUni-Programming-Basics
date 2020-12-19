using System;

namespace _03._World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            char pictureWithTrofee = char.Parse(Console.ReadLine());

            double priceForPicture = 0;
            double priceOfTicket = 0;

            if (ticketType == "Standard")
            {
                if (tournamentStage == "Quarter final")
                {
                    priceOfTicket = 55.50;
                }
                else if (tournamentStage == "Semi final")
                {
                    priceOfTicket = 75.88;
                }
                else if (tournamentStage == "Final")
                {
                    priceOfTicket = 110.10;
                }
            }
            else if (ticketType == "Premium")
            {
                if (tournamentStage == "Quarter final")
                {
                    priceOfTicket = 105.20;
                }
                else if (tournamentStage == "Semi final")
                {
                    priceOfTicket = 125.22;
                }
                else if (tournamentStage == "Final")
                {
                    priceOfTicket = 160.66;
                }
            }
            else if (ticketType == "VIP")
            {
                if (tournamentStage == "Quarter final")
                {
                    priceOfTicket = 118.90;
                }
                else if (tournamentStage == "Semi final")
                {
                    priceOfTicket = 300.40;
                }
                else if (tournamentStage == "Final")
                {
                    priceOfTicket = 400;
                }
            }
            double total = priceOfTicket * numberOfTickets;

            if (pictureWithTrofee == 'Y')
            {
                if (total > 4000)
                {
                    priceForPicture = 0;
                }
                else
                {
                    priceForPicture = numberOfTickets * 40;
                }
                
            }

            if (total > 4000)
            {
                total -= total * 0.25;
            }
            else if (total > 2500)
            {
                total -= total * 0.1;
            }


            double totalPrice = total + priceForPicture;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
