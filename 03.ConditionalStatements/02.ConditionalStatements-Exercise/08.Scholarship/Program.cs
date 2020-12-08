using System;
using System.Runtime.InteropServices;

namespace Scholarship2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double wage = double.Parse(Console.ReadLine()); 
            double grade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            double excellentScholarship = Math.Floor(grade * 25);
            double socialScholarship = Math.Floor(minimalWage * 0.35);

            if (grade >= 5.5 && wage >= minimalWage  )
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }

            else if (grade < 5.5 && wage >= minimalWage  )
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            else if (grade >= 5.5 && wage < minimalWage && socialScholarship <= excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }

            else if (grade > 4.5 && wage < minimalWage)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }

            else if (grade <= 4.5 && wage < minimalWage )
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
