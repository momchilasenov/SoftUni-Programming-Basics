using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

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
                lastProblem = problemName;
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



        }
    }
}
