using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double excellent = 0;
            double veryGood = 0;
            double good = 0;
            double fail = 0;
            double averageGrade = 0;
            double gradeSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade; 

                if (grade >= 5.00)
                {
                    excellent++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    veryGood++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    good++;
                }
                else if (grade < 3.00)
                {
                    fail++;
                }
            }
            averageGrade = gradeSum / n;

            Console.WriteLine($"Top students: {excellent / n * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {veryGood / n * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {good / n * 100:f2}%");
            Console.WriteLine($"Fail: {fail / n * 100:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
