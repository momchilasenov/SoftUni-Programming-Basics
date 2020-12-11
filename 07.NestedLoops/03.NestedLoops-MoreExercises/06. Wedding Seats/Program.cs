using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsInSector1 = int.Parse(Console.ReadLine());
            int oddRowSeats = int.Parse(Console.ReadLine());

            int totalSeats = 0;

            bool flag = false;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                if (sector != 'A') //ако секторът не е A то го увеличаваме с 1
                {
                    rowsInSector1++;
                }

                for (int rows = 1; rows <= rowsInSector1; rows++)
                {
                    int oddCounter = 0;

                    for (char evenSeats = 'a'; evenSeats <= 'a' + oddRowSeats + 1; evenSeats++)
                    {
                        for (char oddSeats = 'a'; oddSeats <= 'a' + oddRowSeats - 1; oddSeats++)
                        {
                            if (rows % 2 != 0)
                            {
                                oddCounter++;
                                Console.WriteLine($"{sector}{rows}{oddSeats}");
                                totalSeats++;
                                if (oddCounter == oddRowSeats)
                                {
                                    flag = true;
                                    break;
                                }

                            }
                            else
                            {
                                Console.WriteLine($"{sector}{rows}{evenSeats}");
                                totalSeats++;
                                break;
                            }

                        }
                        if (flag)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(totalSeats);
        }
    }
}

