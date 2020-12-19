using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            string command1 = Console.ReadLine();
            string command2 = Console.ReadLine();

            int points1 = 0;
            int points2 = 0;


            while (command1 != "End of game")
            { // щом влизаме значи сме получили карта
                int card1 = int.Parse(command1);
                int card2 = int.Parse(command2);

                if (card1 > card2)
                {
                    points1 += card1 - card2;
                }
                else if (card1 < card2)
                {
                    points2 += card2 - card1;
                }
                else if (card1 == card2)
                {
                    Console.WriteLine("Number wars!");
                    int extraCard1 = int.Parse(Console.ReadLine());
                    int extraCard2 = int.Parse(Console.ReadLine());
                    if (extraCard1 > extraCard2)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {points1} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {points2} points");
                        break;
                    }


                }

                command1 = Console.ReadLine();
                if (command1 == "End of game")
                {
                    break;
                }
                command2 = Console.ReadLine();

            }
            if (command1 == "End of game")
            {
                Console.WriteLine($"{firstPlayer} has {points1} points");
                Console.WriteLine($"{secondPlayer} has {points2} points");
            }

        }
    }
}
