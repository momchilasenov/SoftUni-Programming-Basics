using System;

namespace bool
{
    class Program
{
    static void Main(string[] args)
    {
        //Следните две програми работят по един и същ начин но едната включва булева променлива:

        int failed = 0;
        bool studentExcluded = false; //default състояние при което никой не е изключен

        while (gradeCounter <= 12)
        {
            if (failed == 2)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
                Environment.Exit(0); //с това приключваш цялата програма, нищо друго не се изпълнява
            }
        }

        double averageGrade = sumGrades / 12;
        Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");

        //--------------------------------------------------------------------------------

        int failed = 0;
        bool studentExcluded = false; //default състояние при което никой не е изключен

        while (gradeCounter <= 12)
        {
            if (failed == 2)
            {
                Console.WriteLine($"{name} has been excluded at {gradeCounter} grade");
                studentExcluded = true;
                break;
            }
        }
        if (!studentExcluded) //да се принтира само ако не е изключен
        {
            double averageGrade = sumGrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
 
    }
}
}
