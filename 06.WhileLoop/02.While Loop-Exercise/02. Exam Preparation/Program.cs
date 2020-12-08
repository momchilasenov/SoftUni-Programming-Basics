using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int inadequateGrades = int.Parse(Console.ReadLine());

            //string problem = "";
            //int grade = 0;
            //string input = "";

            //int gradeSum = 0;
            //int numberOfProblems = 0;
            //int poorGrades = 0;

            //while (input != "Enough")
            //{
            //    input = Console.ReadLine();
            //    if (input == "Enough")
            //    {
            //        break;
            //    }
            //    if (problem != input && input != "Enough")
            //    {
            //        problem = input;

            //    }
            //    grade = int.Parse(Console.ReadLine());

            //    if (grade <= 4)
            //    {
            //        poorGrades++;
            //        if (poorGrades == inadequateGrades)
            //        {
            //            break;
            //        }
            //    }
            //    gradeSum += grade;
            //    numberOfProblems++;
            //}
            //if (input == "Enough")
            //{
            //    Console.WriteLine($"Average score: { gradeSum * 1.0 / numberOfProblems:f2}");
            //    Console.WriteLine($"Number of problems: {numberOfProblems}");
            //    Console.WriteLine($"Last problem: {problem}");
            //}
            //else
            //{
            //    Console.WriteLine($"You need a break, {inadequateGrades} poor grades.");
            //}


            // ОПТИМИЗАЦИЯ НА КОДА
            int failedExam = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedProblems = 0;
            double gradesSum = 0;
            string lastProblem = "";
            bool isFailed = false;

            while (failedExam > failedTimes)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                    if (failedExam == failedTimes)
                    {
                        isFailed = true;
                        break;
                    }
                }
                gradesSum += grade;
                solvedProblems++;
                lastProblem = problemName;//при команда Enough така и не стига до тук за да презапише lastProblem
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedExam} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: { gradesSum / solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

            //Как точно можеш да създаваш променлива извън цикъла и да я променяш втори път в него
            //string task = Console.ReadLine(); //веднъж чете задача тук

            //while (task != "Enough")
            //{
            //    lastProblem = task;                         //
            //    int grade = int.Parse(Console.ReadLine());  //минава през всички промени тук
            //    gradeCounter++;                             //
            //    sumGrade += grade;                          //

            //    if...


            //    task = Console.ReadLine(); //и накрая променя името на задачата
            //}

        }
    }
}
