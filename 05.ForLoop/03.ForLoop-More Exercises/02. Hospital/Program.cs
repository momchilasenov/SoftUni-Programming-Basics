using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int currentDay = 1; currentDay <= numberOfDays; currentDay++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (currentDay % 3 == 0 && treatedPatients < untreatedPatients)
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    untreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
                
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");

        }
    }
}
