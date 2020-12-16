using System;

namespace _05._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judges = int.Parse(Console.ReadLine());

            double score = 0;

            for (int i = 1; i<= judges; i++)
            {
                string nameOfJudge = Console.ReadLine();
                double pointsOfJudge = double.Parse(Console.ReadLine());

                score = (nameOfJudge.Length * pointsOfJudge) / 2;

                academyPoints += score;
                if (academyPoints > 1250.5)
                {
                    break;
                }
                                
            }
            if (academyPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - academyPoints:f1} more!");
            }
        }
    }
}
