using System;
using System.Runtime.InteropServices;

namespace Scholarship2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тук решението тръгва отгоре надолу - ако има право за отлична и ако няма, ако има право за двете, ако имаш право само на социална и ако няма
            //input
            double wage = double.Parse(Console.ReadLine()); 
            double grade = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            // стипендия за успех = оценка * 25 и социална е МРЗ*35% (закръглени надолу)
            double excellentScholarship = Math.Floor(grade * 25);
            double socialScholarship = Math.Floor(minimalWage * 0.35);

            //ако успех над 5.50 и заплата над МРЗ
            if (grade >= 5.5 && wage >= minimalWage  )
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            //ако успехът е под 5.5 и не отговаря на условията за заплата 
            else if (grade < 5.5 && wage >= minimalWage  )
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            //ако се класира и за двете, но тази за успех е ПО-ГОЛЯМА или РАВНА на социалната получава за успех
            else if (grade >= 5.5 && wage < minimalWage && socialScholarship <= excellentScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentScholarship} BGN");
            }
            //Ако не влезе в горния иф то ще влезе в долния където ще получиш социална стипендия
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
