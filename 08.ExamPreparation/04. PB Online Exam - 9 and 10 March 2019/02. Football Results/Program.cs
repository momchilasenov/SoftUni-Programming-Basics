using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstMatch = Console.ReadLine();
            //string secondMatch = Console.ReadLine();
            //string thirdMatch = Console.ReadLine();

            int wonGames = 0;
            int lostGames = 0;
            int drawnGames = 0;

            for (int i= 1; i<=3; i++)
            {
                string match = Console.ReadLine();
                int first = int.Parse(match[0].ToString());
                int second = int.Parse(match[2].ToString());
                
                if (first > second)
                {
                    wonGames++;
                }
                else if (first < second)
                {
                    lostGames++;
                }
                else if (first == second)
                {
                    drawnGames++;
                }

            }
            Console.WriteLine($"Team won {wonGames} games.");
            Console.WriteLine($"Team lost {lostGames} games.");
            Console.WriteLine($"Drawn games: {drawnGames}");

            //char number = firstMatch[0];
            //int result1 = int.Parse(number.ToString());
            //Console.WriteLine(goal1);

            //char number2 = firstMatch[2];
            //int result2 = int.Parse(number2.ToString());


        }
    }
}
