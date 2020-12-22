using System;

namespace _02._Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleInGroup = int.Parse(Console.ReadLine());
            int strengthPerPerson = int.Parse(Console.ReadLine());
            int bloodOfIllidian = int.Parse(Console.ReadLine());

            double totalStrength = peopleInGroup * strengthPerPerson;

            if (totalStrength >= bloodOfIllidian)
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalStrength-bloodOfIllidian} points.");
            }
            else
            {
                Console.WriteLine($"You are not prepared! You need {bloodOfIllidian-totalStrength} more points.");
            }
        }
    }
}
