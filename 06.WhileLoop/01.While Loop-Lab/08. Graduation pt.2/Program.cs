using System;
using System.Runtime.Versioning;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            double grade = 0;
            int yearCount = 1;
            double gradeSum = 0;
            int failedYears = 0;
            bool youFailed = false;

            while (yearCount <= 12)
            {
                
                if (failedYears == 2)
                {
                    youFailed = true;
                    break;
                }

                grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    failedYears++;
                    continue; 
                                        
                }

                gradeSum += grade;
                yearCount++;

            }
            if (yearCount > 12)
            {
                double averageGrade = gradeSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
            if (youFailed)
            {
                Console.WriteLine($"{name} has been excluded at {yearCount} grade");
            }


        }
    }
}
