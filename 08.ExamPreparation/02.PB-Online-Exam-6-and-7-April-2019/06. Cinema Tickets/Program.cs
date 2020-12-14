using System;
using System.Data;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine(); //taxi

            bool flag = false;
            double totalCount = 0;
            int totalStudentCount = 0;
            int totalStandardCount = 0;
            int totalKidCount = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());

                int currentSeats = 0;
                int studentCount = 0;
                int standardCount = 0;
                int kidCount = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        Console.WriteLine($"{movie} - {currentSeats*1.0/availableSeats*100:f2}% full.");
                        break;
                    }

                    else if (ticketType == "Finish")
                    {
                        Console.WriteLine($"{movie} - {currentSeats * 1.0 / availableSeats * 100:f2}% full.");
                        flag = true;
                        break;
                    }


                    if (ticketType == "student")
                    {
                        studentCount++;
                        totalStudentCount++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCount++;
                        totalStandardCount++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidCount++;
                        totalKidCount++;
                    }
                    currentSeats = studentCount + standardCount + kidCount;
                    totalCount = totalStandardCount + totalStudentCount + totalKidCount;
                    if (currentSeats == availableSeats)
                    {
                        Console.WriteLine($"{movie} - {currentSeats * 1.0 / availableSeats * 100:f2}% full.");
                        break;
                    }
                    

                }
                if (flag)
                {
                    break;
                }
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalCount}");
            Console.WriteLine($"{totalStudentCount*1.0/totalCount*100:f2}% student tickets.");
            Console.WriteLine($"{totalStandardCount*1.0/totalCount*100:f2}% standard tickets.");
            Console.WriteLine($"{totalKidCount*1.0/totalCount*100:f2}% kids tickets.");

        }
    }
}

