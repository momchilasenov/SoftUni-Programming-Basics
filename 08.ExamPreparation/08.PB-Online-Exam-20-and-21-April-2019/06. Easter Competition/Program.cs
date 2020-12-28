using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEasterBreads = int.Parse(Console.ReadLine());
            int maxGrade = 0;
            string maxChef = "";
                                 
            for (int chefs = 1; chefs <= numberOfEasterBreads; chefs++)
            {
                string chefName = Console.ReadLine(); 
                string command = Console.ReadLine(); 
                int gradeSum = 0; 

                while (command != "Stop")
                {
                    int gradeForBread = int.Parse(command); 
                    gradeSum += gradeForBread; 

                    command = Console.ReadLine(); 
                }
                Console.WriteLine($"{chefName} has {gradeSum} points.");

                if (gradeSum > maxGrade)
                {
                    maxGrade = gradeSum;
                    maxChef = chefName;
                    Console.WriteLine($"{chefName} is the new number 1!");
                }
            }
            Console.WriteLine($"{maxChef} won competition with {maxGrade} points!");
        }
    }
}
