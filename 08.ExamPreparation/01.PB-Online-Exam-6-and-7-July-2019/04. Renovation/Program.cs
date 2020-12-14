using System;

namespace _04._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int percentageToNotPaint = int.Parse(Console.ReadLine());

            int area = wallHeight * wallWidth * 4;
            double areaToPaint = Math.Ceiling(area - (area * ((percentageToNotPaint * 1.0) / 100)));

            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                int letersOfPaint = int.Parse(command);

                areaToPaint -= letersOfPaint;

                if (areaToPaint==0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }
                if (areaToPaint <= 0 && letersOfPaint > 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaToPaint)} l paint left!");
                    break;
                }


                command = Console.ReadLine();
            }
            if (command == "Tired!")
            {
                Console.WriteLine($"{areaToPaint} quadratic m left.");
            }
            

        }
    }
}
