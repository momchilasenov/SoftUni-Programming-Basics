using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            int totalPeople = 0;

            double climbingMusala = 0;
            double climbingMonblan = 0;
            double climbingKilimanjaro = 0;
            double climbingK2 = 0;
            double climbingEverest = 0;

            for (int i = 1; i <= numberOfGroups; i++)
            {
                int peopleInGroup = int.Parse(Console.ReadLine());
                totalPeople += peopleInGroup;

                if (peopleInGroup <= 5)
                {
                    climbingMusala += peopleInGroup * 100;
                }
                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    climbingMonblan += peopleInGroup * 100;
                }
                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    climbingKilimanjaro += peopleInGroup * 100;
                }
                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    climbingK2 += peopleInGroup * 100;
                }
                else if (peopleInGroup >= 41)
                {
                    climbingEverest += peopleInGroup * 100;
                }
            }
            Console.WriteLine($"{climbingMusala / totalPeople:f2}%");
            Console.WriteLine($"{climbingMonblan / totalPeople:f2}%");
            Console.WriteLine($"{climbingKilimanjaro / totalPeople:f2}%");
            Console.WriteLine($"{climbingK2 / totalPeople:f2}%");
            Console.WriteLine($"{climbingEverest / totalPeople:f2}%");



        }
    }
}
