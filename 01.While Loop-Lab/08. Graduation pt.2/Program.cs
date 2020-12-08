using System;
using System.Runtime.Versioning;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //double grade = 0;
            //int gradeCounter = 1;
            //double sumGrades = 0;
            //int failed = 0;
            //bool studentExcluded = false;

            //while (gradeCounter <= 12)
            //{
            //    if (failed == 2)
            //    {
            //        Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
            //        studentExcluded = true;
            //        break;
            //    }

            //    grade = double.Parse(Console.ReadLine());

            //    if (grade < 4.00)
            //    {
            //        failed++;
            //        continue;
            //    }

            //    sumGrades += grade;
            //    gradeCounter++;
            //}
            //if (!studentExcluded)
            //{
            //    double averageGrade = sumGrades / 12;
            //    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            //}


            //САМОСТОЯТЕЛНО РЕШЕНИЕ
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
                    continue; //пропускаме добавянето на оценка и година!
                                        
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
