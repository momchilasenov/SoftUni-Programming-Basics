using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double grade = 0; 
            double totalGrades = 0;
            
            while (command != "Finish")
            { 
                double averageGrade = 0; 
                double currentPresentationGradesSum = 0; 
                for (int i = 1; i <= jury; i++) 
                {
                    grade = double.Parse(Console.ReadLine());
                    currentPresentationGradesSum += grade;
                    totalGrades += grade;
                    gradeCounter++;
                }
                averageGrade = currentPresentationGradesSum / jury;
                Console.WriteLine($"{command} - {averageGrade:f2}.");

                command = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalGrades / gradeCounter:f2}.");

        }
    }
}
