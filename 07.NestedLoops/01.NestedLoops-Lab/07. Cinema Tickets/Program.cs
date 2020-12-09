using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int allTicketsPerMovie = 0;
            int studentsTickets = 0;
            int kidsTickets = 0;
            int standardTickets = 0;
            int totalTickets = 0;

            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    totalTickets++;
                    allTicketsPerMovie++;
                    if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentsTickets++;
                    }

                    if (allTicketsPerMovie == freeSeats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }
                Console.WriteLine($"{movieName} - {(allTicketsPerMovie * 1.0 / freeSeats) * 100:f2}% full.");
                allTicketsPerMovie = 0;
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentsTickets*1.0 / totalTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(standardTickets*1.0 / totalTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(kidsTickets*1.0 / totalTickets) * 100:f2}% kids tickets.");
        }
    }
}
